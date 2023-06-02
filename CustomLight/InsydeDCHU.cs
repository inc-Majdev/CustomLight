using System;
using System.Runtime.InteropServices;

namespace Clevo
{
    public static class InsydeDCHU
    {
        [DllImport("InsydeDCHU.dll")]
        static extern int SetDCHU_Data(int command, byte[] buffer, int length);

        [DllImport("InsydeDCHU.dll")]
        static extern int WriteAppSettings(int page, int offset, int length, ref byte buffer);

        [DllImport("InsydeDCHU.dll")]
        public static extern int ReadAppSettings(int page, int offset, int length, ref byte buffer);

        [DllImport("InsydeDCHU.dll")]
        public static extern int GetDCHU_Data_Integer(int command, ref int data);

        public static void TurnOff()
        {
            SetDCHU_Data(103, new byte[4] { 0, 0, 0, 224 }, 4);
            WriteAppSettings(2, 84, 1, ref new byte[1] { 0 }[0]);
        }

        public static void TurnOn()
        {
            SetDCHU_Data(103, new byte[4] { 0, 0, 1, 224 }, 4);
            WriteAppSettings(2, 84, 1, ref new byte[1] { 1 }[0]);
        }

        public static bool GetPowerState()
        {
            byte status = 0;
            ReadAppSettings(2, 84, 1, ref status);
            return Convert.ToBoolean(status);
        }

        public static void SetColor(byte R, byte G, byte B, byte A = 0)
        {
            SetDCHU_Data(103, new byte[4] { G, R, B, 240 }, 4);
            WriteAppSettings(2, 81, 3, ref new byte[3] { R, G, B }[0]);
            WriteAppSettings(2, 32, 1, ref new byte[1] { 8 }[0]);
            if(A > 0)
                SetBrightness(A);
        }

        public static void SetBrightness(byte value)
        {
            SetDCHU_Data(103, new byte[4] { value, 0, 0, 244 }, 4);
            WriteAppSettings(2, 35, 1, ref new byte[1] { value }[0]);
        }

        public static void OverrideBootEffect(bool value)
        {
            byte num = (byte)(value ? 1 : 0);
            SetDCHU_Data(121, new byte[4] { num, 0, 0, 30 }, 4);
            WriteAppSettings(2, 7, 1, ref new byte[1] { num }[0]);
        }
    }
}
