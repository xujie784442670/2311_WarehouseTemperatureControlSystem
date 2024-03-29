using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WtcsModbusManager;

namespace 仓库温控系统
{
    public partial class FormModBusTest : Form
    {
        private ModeBusHelper _modeBusHelper;

        public FormModBusTest()
        {
            InitializeComponent();
        }

        private void FormModBusTest_Load(object sender, EventArgs e)
        {
            var interfaces = ModeBusHelper.GetNetworkInterfaces();
            hostCb.Items.AddRange(interfaces.ToArray());
            hostCb.SelectedItem = interfaces.FirstOrDefault();
            // 保留names前俩个元素
            dataTypeCb.Items.AddRange(Enum.GetNames(typeof(DataType)));
        }

        private void subscribedCb_CheckedChanged(object sender, EventArgs e)
        {
            if (_modeBusHelper == null) return;
            _modeBusHelper.ScanInterval = int.Parse(textBox1.Text);
            _modeBusHelper.IsSubscribed = subscribedCb.Checked;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _modeBusHelper = ModeBusHelper.Create(hostCb.SelectedItem?.ToString(), int.Parse(portCb.Text));
            _modeBusHelper.Connect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 获取选择的数据类型
            Enum.TryParse<DataType>(dataTypeCb.SelectedItem?.ToString(), out var dataType);
            // 获取长度
            var length = ushort.Parse(lenTb.Text);
            // 获取从站地址
            var slaveId = byte.Parse(slaveTb.Text);
            // 获取寄存器起始地址
            var address = ushort.Parse(addrTb.Text);
            // 查看选择的数据类型是否是线圈
            if (dataType == DataType.Coil)
            {
                // 如果长度小于2,则读取单个线圈
                if (length < 2)
                {
                    // 异步读取单个线圈
                    var task = _modeBusHelper.AsyncReadSingleCoil(slaveId, address);
                    task.ContinueWith(t => { this.Invoke(() => { bTb.Text = t.Result.ToString(); }); });
                }
                else
                {
                    // 异步读取多个线圈
                    var task = _modeBusHelper.AsyncReadMultipleCoils(slaveId, address, length);
                    task.ContinueWith(t => { this.Invoke(() => { bsTb.Text = $"[{string.Join(",", t.Result)}]"; }); });
                }
            }
            // 如果选择的数据类型为保持寄存器
            else if (dataType == DataType.HoldingRegister)
            {
                // 如果长度小于2,则读取单个寄存器
                if (length < 2)
                {
                    // 异步读取单个寄存器
                    var task = _modeBusHelper.AsyncReadSingleRegister(slaveId, address);
                    task.ContinueWith(t => { this.Invoke(() => { uTb.Text = t.Result.ToString(); }); });
                }
                else
                {
                    // 异步读取多个寄存器
                    var task = _modeBusHelper.AsyncReadMultipleRegisters(slaveId, address, length);
                    task.ContinueWith(t => { this.Invoke(() => { usTb.Text = $"[{string.Join(",", t.Result)}]"; }); });
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 获取选择的数据类型
            Enum.TryParse<DataType>(dataTypeCb.SelectedItem?.ToString(), out var dataType);
            // 获取长度
            var length = ushort.Parse(lenTb.Text);
            // 获取从站地址
            var slaveId = byte.Parse(slaveTb.Text);
            // 获取寄存器起始地址
            var address = ushort.Parse(addrTb.Text);
            // 查看选择的数据类型是否是线圈
            if (dataType == DataType.Coil)
            {
                // 如果长度小于2,则读取单个线圈
                if (length < 2)
                {
                    this.Invoke(() =>
                    {
                        // 同步读取单个线圈
                        bTb.Text = _modeBusHelper.ReadSingleCoil(slaveId, address).ToString();
                    });
                }
                else
                {
                    // 读取多个线圈
                    // 将结果显示到界面上
                    this.Invoke(() =>
                    {
                        // 同步读取多个线圈
                        var result = _modeBusHelper.ReadMultipleCoils(slaveId, address, length);
                        bsTb.Text = $"[{string.Join(",", result)}]";
                    });
                }
            }
            // 如果选择的数据类型为保持寄存器
            else if (dataType == DataType.HoldingRegister)
            {
                // 如果长度小于2,则读取单个寄存器
                if (length < 2)
                {
                    this.Invoke(() => { uTb.Text = _modeBusHelper.ReadSingleRegister(slaveId, address).ToString(); });
                }
                else
                {
                    this.Invoke(() =>
                    {
                        // 读取多个寄存器
                        var result = _modeBusHelper.ReadMultipleRegisters(slaveId, address, length);
                        usTb.Text = $"[{string.Join(",", result)}]";
                    });
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 获取选择的数据类型
            Enum.TryParse<DataType>(dataTypeCb.SelectedItem?.ToString(), out var dataType);
            // 获取长度
            var length = ushort.Parse(lenTb.Text);
            // 获取从站地址
            var slaveId = byte.Parse(slaveTb.Text);
            // 获取寄存器起始地址
            var address = ushort.Parse(addrTb.Text);
            var sensorInfo = new SensorInfo
            {
                SlaveId = slaveId,
                Address = address,
                Length = length,
                DataType = dataType
            };
            // 因为界面上只能展示一个传感器的数据,所以每次订阅传感器数据时,
            // 先清空之前订阅的传感器数据
            _modeBusHelper.ClearSubscribedSensorInfos();
            {
                // 单纯订阅传感器数据,然后通过OnSensorDataReceived事件处理数据
                // _modeBusHelper.SubscribeSensorInfo(sensorInfo);
                // 订阅传感器数据后,需要在OnSensorDataReceived事件中处理数据
                // 此事件会在任意已订阅的传感器数据发生变化时触发
                // _modeBusHelper.OnSensorDataReceived += _modeBusHelper_OnSensorDataReceived;
            }
            {
                // 订阅传感器数据,并且只在当前传感器数据发生变化时触发事件
                _modeBusHelper.SubscribeSensorInfo(sensorInfo, _modeBusHelper_OnSensorDataReceived);
            }
        }

        private void _modeBusHelper_OnSensorDataReceived(SensorInfo arg1, DataValue value)
        {
            this.Invoke(() =>
            {
                fTb.Text = value.ToFloat().ToString();
                fsTb.Text = $"[{string.Join(",", value.ToFloats())}]";
                uTb.Text = value.ToUShort().ToString();
                usTb.Text = $"[{string.Join(",", value.ToUShort())}]";
                bTb.Text = value.ToBool().ToString();
                bsTb.Text = $"[{string.Join(",", value.ToBools())}]";
            });
        }
    }
}