using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Modbus.Device;

namespace WtcsModbusManager;

public class ModeBusHelper : IDisposable
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string Id { get; private set; } = Guid.NewGuid().ToString();

    public TcpClient TcpClient { get; private set; }

    /// <summary>
    /// 是否连接
    /// </summary>
    public bool IsConnected => TcpClient?.Connected ?? false;

    public ModbusIpMaster ModBusIpMaster { get; private set; }

    private Dictionary<string, SensorInfo> _sensorInfos = new();

    public event Action<SensorInfo, DataValue> OnSensorDataReceived;

    public Dictionary<string, Action<SensorInfo, DataValue>> SensorDataReceivedActions { get; } = new();

    /// <summary>
    /// 扫描间隔(单位: ms),默认1s
    /// </summary>
    public int ScanInterval { get; set; } = 1000;

    private bool _isSubscribing = false;

    private Thread _scanThread;

    public readonly string Host;

    public readonly int Port;

    public ModeBusHelper(string id, string host, int port)
    {
        Id = string.IsNullOrWhiteSpace(id) ? Id : id;
        Host = host;
        Port = port;
    }

    public ModeBusHelper(string host, int port) : this(null, host, port)
    {
    }

    /// <summary>
    /// 是否开启订阅
    /// </summary>
    public bool IsSubscribed
    {
        get => _isSubscribing;
        set
        {
            _isSubscribing = value;
            if (_isSubscribing)
            {
                _scanThread = new Thread(Scanner)
                {
                    IsBackground = true
                };
                _scanThread.Start();
            }
            else
            {
                _scanThread.Abort();
            }
        }
    }

    /// <summary>
    /// 订阅的传感器信息
    /// </summary>
    public List<SensorInfo> SubscribedSensorInfos => new(_sensorInfos.Values.ToList());

    /// <summary>
    /// 获取本机所有网络接口
    /// </summary>
    /// <returns></returns>
    public static List<string> GetNetworkInterfaces()
    {
        var interfaces = new List<string>();
        // 得到所有网卡的IP地址
        var ips = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName());
        foreach (var ip in ips)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                interfaces.Add(ip.ToString());
            }
        }

        return interfaces;
    }

    public static ModeBusHelper Create(string ip, int port, string? id = null)
    {
        var helper = new ModeBusHelper(id, ip, port);
        return helper;
    }

    private void DispatcherSensorDataReceivedActions(SensorInfo sensorInfo, DataValue dataValue)
    {
        if (SensorDataReceivedActions.ContainsKey(sensorInfo.SensorId))
        {
            SensorDataReceivedActions[sensorInfo.SensorId]?.Invoke(sensorInfo, dataValue);
        }
    }


    private void Scanner()
    {
        // 如果未连接,则等待连接
        // 如果订阅列表为空,则等待

        while (!IsConnected || _sensorInfos.Count == 0)
        {
            Thread.Sleep(1000);
        }

        // 如果订阅列表不为空,则开始扫描
        while (IsConnected)
        {
            foreach (var sensorInfo in _sensorInfos.Values)
            {
                try
                {
                    var slaveId = sensorInfo.SlaveId;
                    var address = sensorInfo.Address;
                    var length = sensorInfo.Length;
                    switch (sensorInfo.DataType)
                    {
                        case DataType.Coil:
                        {
                            var task = AsyncReadMultipleCoils(slaveId, address, length);
                            task.ContinueWith(t =>
                            {
                                var result = t.Result;
                                var dataValue = new DataValue
                                {
                                    Value = result
                                };
                                OnSensorDataReceived?.Invoke(sensorInfo, dataValue);
                                DispatcherSensorDataReceivedActions(sensorInfo, dataValue);
                            });
                        }
                            break;
                        case DataType.HoldingRegister:
                        {
                            var task = AsyncReadMultipleRegisters(slaveId, address, length);
                            task.ContinueWith(t =>
                            {
                                var result = t.Result;
                                var dataValue = new DataValue
                                {
                                    Value = result
                                };
                                OnSensorDataReceived?.Invoke(sensorInfo, dataValue);
                                DispatcherSensorDataReceivedActions(sensorInfo, dataValue);
                            });
                        }
                            break;
                        case DataType.InputRegister: throw new NotImplementedException("暂不支持InputRegister类型");
                        case DataType.InputCoil: throw new NotImplementedException("暂不支持InputCoil类型");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}{Environment.NewLine}{e.StackTrace}");
                    throw;
                }
            }

            Thread.Sleep(ScanInterval);
        }
    }

    /// <summary>
    /// 清空订阅的传感器信息
    /// </summary>
    public void ClearSubscribedSensorInfos()
    {
        _sensorInfos.Clear();
    }

    /// <summary>
    /// 订阅传感器信息
    /// </summary>
    /// <param name="sensorInfo"></param>
    /// <exception cref="ArgumentException"></exception>
    public string SubscribeSensorInfo(SensorInfo sensorInfo)
    {
        if (string.IsNullOrWhiteSpace(sensorInfo.SensorId))
        {
            throw new ArgumentException("SensorId不能为空");
        }

        if (_sensorInfos.ContainsKey(sensorInfo.SensorId))
        {
            throw new ArgumentException($"已订阅ID为{sensorInfo.SensorId}的传感器");
        }

        _sensorInfos[sensorInfo.SensorId] = sensorInfo;
        return sensorInfo.SensorId;
    }

    /// <summary>
    /// 订阅传感器信息
    /// </summary>
    /// <param name="sensorInfo">传感器信息</param>
    /// <param name="action">传感器接收到数据的委托</param>
    /// <returns></returns>
    public string SubscribeSensorInfo(SensorInfo sensorInfo, Action<SensorInfo, DataValue> action)
    {
        var sensorId = SubscribeSensorInfo(sensorInfo);
        SensorDataReceivedActions[sensorId] = action;
        return sensorId;
    }

    /// <summary>
    /// 取消订阅传感器信息
    /// </summary>
    /// <param name="sensorId">传感器ID,在订阅时如未指定,则会默认生成</param>
    public void UnSubscribeSensorInfo(string sensorId)
    {
        if (_sensorInfos.ContainsKey(sensorId))
        {
            _sensorInfos.Remove(sensorId);
        }
    }

    /// <summary>
    /// 连接Modbus
    /// </summary>
    /// <param name="ip">MB主机地址</param>
    /// <param name="port">端口</param>
    public void Connect()
    {
        if (!IsConnected)
        {
            TcpClient = new TcpClient();
            TcpClient.Connect(Host, Port);
            ModBusIpMaster = ModbusIpMaster.CreateIp(TcpClient);
        }
    }

    private void CheckConnect()
    {
        if (!IsConnected)
            throw new Exception("未连接ModBus,请调用ModBusHelper.Connect方法进行连接");
    }

    #region 写单个寄存器

    #region 同步写单个寄存器

    /// <summary>
    /// 写单个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="value">值</param>
    /// <param name="isAsync">是否异步</param>
    /// <returns>如果不是异步,则返回的Task会快速完成</returns>
    public Task WriteSingleRegister(byte slaveAddress, ushort startAddress, ushort value, bool isAsync = false)
    {
        CheckConnect();
        try
        {
            if (isAsync)
            {
                return ModBusIpMaster.WriteSingleRegisterAsync(slaveAddress, startAddress, value);
            }
            else
            {
                ModBusIpMaster.WriteSingleRegister(slaveAddress, startAddress, value);
                return Task.CompletedTask;
            }
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
                return Task.CompletedTask;
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// 写单个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="value">值</param>
    public void WriteSingleRegister(byte slaveAddress, ushort startAddress, byte[] value)
    {
        CheckConnect();
        if (value.Length != 2)
            throw new ArgumentException($"value的长度必须为2,当前长度为:{value.Length}");
        // 将byte[]转换为ushort
        ushort[] values = new ushort[value.Length / 2];
        for (int i = 0; i < value.Length; i += 2)
        {
            values[i / 2] = BitConverter.ToUInt16(value, i);
        }

        WriteSingleRegister(slaveAddress, startAddress, values[0]);
    }

    #endregion

    #region 异步写单个寄存器

    /// <summary>
    /// 异步写单个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="value">值</param>
    public Task AsyncWriteSingleRegister(byte slaveAddress, ushort startAddress, ushort value)
    {
        CheckConnect();
        return WriteSingleRegister(slaveAddress, startAddress, value, true);
    }

    /// <summary>
    /// 异步写单个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="value">值</param>
    public Task AsyncWriteSingleRegister(byte slaveAddress, ushort startAddress, byte[] value)
    {
        CheckConnect();
        if (value.Length != 2)
            throw new ArgumentException($"value的长度必须为2,当前长度为:{value.Length}");
        // 将byte[]转换为ushort
        ushort[] values = new ushort[value.Length / 2];
        for (int i = 0; i < value.Length; i += 2)
        {
            values[i / 2] = BitConverter.ToUInt16(value, i);
        }

        return WriteSingleRegister(slaveAddress, startAddress, values[0], true);
    }

    #endregion

    #endregion

    #region 写多个寄存器

    #region 同步写多个寄存器

    /// <summary>
    /// 写多个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="values">值</param>
    public void WriteMultipleRegisters(byte slaveAddress, ushort startAddress, params ushort[] values)
    {
        CheckConnect();
        try
        {
            ModBusIpMaster.WriteMultipleRegisters(slaveAddress, startAddress, values);
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// 写多个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="values">值</param>
    public void WriteMultipleRegisters(byte slaveAddress, ushort startAddress, params byte[] values)
    {
        CheckConnect();
        // 将byte[]转换为ushort
        ushort[] values2 = new ushort[values.Length / 2];
        for (int i = 0; i < values.Length; i += 2)
        {
            values2[i / 2] = BitConverter.ToUInt16(values, i);
        }

        try
        {
            ModBusIpMaster.WriteMultipleRegisters(slaveAddress, startAddress, values2);
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
            }
            else
            {
                throw;
            }
        }
    }

    #endregion

    #region 异步写多个寄存器

    /// <summary>
    /// 异步写多个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="values">值</param>
    /// <returns></returns>
    public Task AsyncWriteMultipleRegisters(byte slaveAddress, ushort startAddress, params ushort[] values)
    {
        CheckConnect();
        try
        {
            return ModBusIpMaster.WriteMultipleRegistersAsync(slaveAddress, startAddress, values);
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
                return Task.CompletedTask;
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// 异步写多个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="values">值</param>
    public Task AsyncWriteMultipleRegisters(byte slaveAddress, ushort startAddress, params byte[] values)
    {
        CheckConnect();
        // 将byte[]转换为ushort
        ushort[] values2 = new ushort[values.Length / 2];
        for (int i = 0; i < values.Length; i += 2)
        {
            values2[i / 2] = BitConverter.ToUInt16(values, i);
        }

        try
        {
            return ModBusIpMaster.WriteMultipleRegistersAsync(slaveAddress, startAddress, values2);
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
                return Task.CompletedTask;
            }
            else
            {
                throw;
            }
        }
    }

    #endregion

    #endregion

    #region 写单个线圈

    /// <summary>
    /// 写单个线圈
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="value">值</param>
    /// <param name="isAsync">是否异步</param>
    /// <returns>如果不是异步,则返回的Task会快速完成</returns>
    public Task WriteSingleCoil(byte slaveAddress, ushort startAddress, bool value, bool isAsync = false)
    {
        CheckConnect();
        try
        {
            if (isAsync)
            {
                return ModBusIpMaster.WriteSingleCoilAsync(slaveAddress, startAddress, value);
            }
            else
            {
                ModBusIpMaster.WriteSingleCoil(slaveAddress, startAddress, value);
                return Task.CompletedTask;
            }
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
                return Task.CompletedTask;
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// 异步写单个线圈
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="value">值</param>
    /// <returns></returns>
    public Task AsyncWriteSingleCoil(byte slaveAddress, ushort startAddress, bool value)
    {
        CheckConnect();
        return WriteSingleCoil(slaveAddress, startAddress, value, true);
    }

    #endregion

    #region 写多个线圈

    /// <summary>
    /// 异步写多个线圈
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="values">值</param>
    /// <returns></returns>
    public Task WriteMultipleCoilsAsync(byte slaveAddress, ushort startAddress, params bool[] values)
    {
        CheckConnect();
        try
        {
            return ModBusIpMaster.WriteMultipleCoilsAsync(slaveAddress, startAddress, values);
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
                return Task.CompletedTask;
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// 同步写多个线圈
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="values">值</param>
    public void WriteMultipleCoils(byte slaveAddress, ushort startAddress, params bool[] values)
    {
        CheckConnect();
        try
        {
            ModBusIpMaster.WriteMultipleCoils(slaveAddress, startAddress, values);
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
            }
            else
            {
                throw;
            }
        }
    }

    #endregion

    #region 读取单个寄存器

    /// <summary>
    /// 读取单个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <returns></returns>
    public byte[] ReadSingleRegisterToBytes(byte slaveAddress, ushort startAddress)
    {
        CheckConnect();
        return BitConverter.GetBytes(ReadSingleRegister(slaveAddress, startAddress));
    }

    /// <summary>
    /// 读取单个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <returns></returns>
    public ushort ReadSingleRegister(byte slaveAddress, ushort startAddress)
    {
        CheckConnect();
        try
        {
            return ModBusIpMaster.ReadHoldingRegisters(slaveAddress, startAddress, 1)[0];
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
                return 0;
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// 异步读取单个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <returns></returns>
    public Task<byte[]> AsyncReadSingleRegisterToBytes(byte slaveAddress, ushort startAddress)
    {
        CheckConnect();
        return AsyncReadSingleRegister(slaveAddress, startAddress)
            .ContinueWith(task => BitConverter.GetBytes(task.Result));
    }

    /// <summary>
    /// 异步读取单个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <returns></returns>
    public Task<ushort> AsyncReadSingleRegister(byte slaveAddress, ushort startAddress)
    {
        CheckConnect();
        try
        {
            return ModBusIpMaster.ReadHoldingRegistersAsync(slaveAddress, startAddress, 1)
                .ContinueWith(task => task.Result[0]);
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
                return Task.FromResult((ushort)0);
            }
            else
            {
                throw;
            }
        }
    }

    #endregion

    #region 读取多个寄存器

    /// <summary>
    /// 同步读取多个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="length">寄存器数量</param>
    /// <returns></returns>
    public ushort[] ReadMultipleRegisters(byte slaveAddress, ushort startAddress, ushort length)
    {
        CheckConnect();
        try
        {
            return ModBusIpMaster.ReadHoldingRegisters(slaveAddress, startAddress, length);
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
                return Array.Empty<ushort>();
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// 同步读取多个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="length">寄存器数量</param>
    /// <returns></returns>
    public byte[] ReadMultipleRegistersToBytes(byte slaveAddress, ushort startAddress, ushort length)
    {
        CheckConnect();
        var result = ReadMultipleRegisters(slaveAddress, startAddress, length);
        byte[] bytes = new byte[result.Length * 2];
        for (int i = 0; i < result.Length; i++)
        {
            byte[] temp = BitConverter.GetBytes(result[i]);
            bytes[i * 2] = temp[0];
            bytes[i * 2 + 1] = temp[1];
        }

        return bytes;
    }

    /// <summary>
    /// 异步读取多个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="length">寄存器数量</param>
    /// <returns></returns>
    public Task<ushort[]> AsyncReadMultipleRegisters(byte slaveAddress, ushort startAddress, ushort length)
    {
        CheckConnect();
        try
        {
            return ModBusIpMaster.ReadHoldingRegistersAsync(slaveAddress, startAddress, length);
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
                return Task.FromResult(Array.Empty<ushort>());
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// 异步读取多个寄存器
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="length">寄存器数量</param>
    /// <returns></returns>
    public Task<byte[]> AsyncReadMultipleRegistersToBytes(byte slaveAddress, ushort startAddress, ushort length)
    {
        CheckConnect();
        return AsyncReadMultipleRegisters(slaveAddress, startAddress, length).ContinueWith(task =>
        {
            var result = task.Result;
            byte[] bytes = new byte[result.Length * 2];
            for (int i = 0; i < result.Length; i++)
            {
                byte[] temp = BitConverter.GetBytes(result[i]);
                bytes[i * 2] = temp[0];
                bytes[i * 2 + 1] = temp[1];
            }

            return bytes;
        });
    }

    #endregion

    #region 读取单个线圈

    /// <summary>
    /// 同步读取单个线圈
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <returns></returns>
    public bool ReadSingleCoil(byte slaveAddress, ushort startAddress)
    {
        CheckConnect();
        try
        {
            return ModBusIpMaster.ReadCoils(slaveAddress, startAddress, 1)[0];
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
                return false;
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// 异步读取单个线圈
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <returns></returns>
    public Task<bool> AsyncReadSingleCoil(byte slaveAddress, ushort startAddress)
    {
        CheckConnect();
        try
        {
            return ModBusIpMaster.ReadCoilsAsync(slaveAddress, startAddress, 1).ContinueWith(task => task.Result[0]);
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
                return Task.FromResult(false);
            }
            else
            {
                throw;
            }
        }
    }

    #endregion

    #region 读取多个线圈

    /// <summary>
    /// 同步读取多个线圈
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="length">线圈数量</param>
    /// <returns></returns>
    public bool[] ReadMultipleCoils(byte slaveAddress, ushort startAddress, ushort length)
    {
        CheckConnect();
        try
        {
            return ModBusIpMaster.ReadCoils(slaveAddress, startAddress, length);
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
                return Array.Empty<bool>();
            }

            throw;
        }
    }

    /// <summary>
    /// 异步读取多个线圈
    /// </summary>
    /// <param name="slaveAddress">从站地址</param>
    /// <param name="startAddress">寄存器起始地址</param>
    /// <param name="length">线圈数量</param>
    /// <returns></returns>
    public Task<bool[]> AsyncReadMultipleCoils(byte slaveAddress, ushort startAddress, ushort length)
    {
        CheckConnect();
        try
        {
            return ModBusIpMaster.ReadCoilsAsync(slaveAddress, startAddress, length);
        }
        catch (Exception e)
        {
            // 检查是否是因为网络断开而产生的异常
            if (e is InvalidOperationException)
            {
                Dispose();
                return Task.FromResult(Array.Empty<bool>());
            }

            throw;
        }
    }

    #endregion

    /// <summary>
    /// 释放资源
    /// </summary>
    public void Dispose()
    {
        ModBusIpMaster?.Dispose();
        TcpClient?.Dispose();
    }
}