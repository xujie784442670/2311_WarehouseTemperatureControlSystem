#nullable enable
using System;

namespace WtcsModbusManager;

public class DataValue
{
    public object? Value { get; set; }

    public DateTime Time => DateTime.Now;

    public ushort? ToUShort()
    {
        if (Value == null) return null;
        if (Value is ushort[] us)
        {
            return us[0];
        }

        if (Value is bool[] bs)
        {
            return bs[0] ? (ushort)1 : (ushort)0;
        }

        return 0;
    }

    public bool? ToBool()
    {
        if (Value == null) return null;
        if (Value is bool[] bs)
        {
            return bs[0];
        }

        if (Value is ushort[] us)
        {
            return us[0] == 1;
        }

        return false;
    }
    public ushort[] ToUShorts()
    {
        if (Value is ushort[] us)
        {
            return us;
        }

        if (Value is bool[] bs)
        {
            ushort[] uss = new ushort[bs.Length];
            for (int i = 0; i < bs.Length; i++)
            {
                uss[i] = bs[i] ? (ushort)1 : (ushort)0;
            }

            return uss;
        }
        return Array.Empty<ushort>();
    }

    public bool[] ToBools()
    {
        if (Value is bool[] bs)
        {
            return bs;
        }

        if (Value is ushort[] us)
        {
            bool[] bss = new bool[us.Length];
            for (int i = 0; i < us.Length; i++)
            {
                bss[i] = us[i] == 1;
            }

            return bss;
        }
        return Array.Empty<bool>();
    }

    public float? ToFloat()
    {
        if (Value == null) return null;
        if (Value is ushort[] fs)
        {
            // 将ushort[]转换为byte[]
            byte[] bytes = new byte[fs.Length * 2];
            for (int i = 0; i < fs.Length; i++)
            {
                byte[] temp = BitConverter.GetBytes(fs[i]);
                bytes[i * 2] = temp[0];
                bytes[i * 2 + 1] = temp[1];
            }

            // 检查bytes长度是否足够,如果不足够则补0
            if (bytes.Length < 4)
            {
                // 补0,使其满足float转换的结构
                byte[] temp = new byte[4];
                for (int i = 0; i < bytes.Length; i++)
                {
                    temp[i] = bytes[i];
                }

                bytes = temp;
            }

            return BitConverter.ToSingle(bytes, 0);
        }
        return 0;
    }

    public float[] ToFloats()
    {
        if (Value == null) return Array.Empty<float>();
        if (Value is ushort[] fs)
        {
            // 将ushort[]转换为byte[]
            byte[] bytes = new byte[fs.Length * 2];
            for (int i = 0; i < fs.Length; i++)
            {
                byte[] temp = BitConverter.GetBytes(fs[i]);
                bytes[i * 2] = temp[0];
                bytes[i * 2 + 1] = temp[1];
            }

            if (bytes.Length < 4)
            {
                // 补0,使其满足float转换的结构
                byte[] temp = new byte[4];
                for (int i = 0; i < bytes.Length; i++)
                {
                    temp[i] = bytes[i];
                }

                bytes = temp;
            }
            // 将byte[]转换为float[]
            float[] result = new float[bytes.Length / 4];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = BitConverter.ToSingle(bytes, i * 4);
            }
            return result;
        }
        return Array.Empty<float>();
    }
}