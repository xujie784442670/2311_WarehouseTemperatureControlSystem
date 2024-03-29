using System;

namespace WtcsModbusManager;

/// <summary>
/// 传感器信息
/// </summary>
public class SensorInfo
{
    /// <summary>
    /// 传感器ID(唯一标识,默认为自动生成的Guid)
    /// </summary>
    public string SensorId { get; set; } = Guid.NewGuid().ToString();

    /// <summary>
    /// 传感器名称
    /// </summary>
    public string SensorName { get; set; }

    /// <summary>
    /// 从站地址
    /// </summary>
    public byte SlaveId { get; set; }

    /// <summary>
    /// 寄存器地址
    /// </summary>
    public ushort Address { get; set; }

    /// <summary>
    /// 寄存器长度
    /// </summary>
    public ushort Length { get; set; } = 1;

    /// <summary>
    /// 传感器类型
    /// </summary>
    public DataType DataType { get; set; }
}

/// <summary>
/// 传感器类型
/// </summary>
public enum DataType
{
    /// <summary>
    /// 线圈
    /// </summary>
    Coil,

    /// <summary>
    /// 保持寄存器
    /// </summary>
    HoldingRegister,

    /// <summary>
    /// 输入寄存器
    /// </summary>
    InputRegister,

    /// <summary>
    /// 输入线圈
    /// </summary>
    InputCoil
}