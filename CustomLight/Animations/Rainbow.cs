using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CustomLight.Animations
{
    internal class Rainbow
    {
        static Timer timerR;
        static Timer timerB;
        static Timer timerG;

        static int r = 244;
        static int g = 65;
        static int b = 65;

        public static int CurrentSpeed = 5;
        public static Color CurrentColor;

        public static void Setup()
        {
            if (CurrentSpeed <= 0)
            {
                CurrentSpeed = 1;
            }
            var TemptimerR = new Timer(20 / CurrentSpeed);
            TemptimerR.Elapsed += new ElapsedEventHandler(timerR_Elapsed);
            TemptimerR.Enabled = false;
            timerR = TemptimerR;

            var TemptimerG = new Timer(20 / CurrentSpeed);
            TemptimerG.Elapsed += new ElapsedEventHandler(timerG_Elapsed);
            TemptimerG.Enabled = false;
            timerG = TemptimerG;

            var TemptimerB = new Timer(20 / CurrentSpeed);
            TemptimerB.Elapsed += new ElapsedEventHandler(timerB_Elapsed);
            TemptimerB.Enabled = false;
            timerB = TemptimerB;

            timerB.Start();
        }

        static void Restore()
        {
            timerR.Stop();
            timerG.Stop();
            timerB.Stop();
            timerR = null;
            timerG = null;
            timerB = null;
            r = 244;
            g = 65;
            b = 65;
            CurrentColor = Color.Empty;
            Setup();
        }
        public static void SetSpeed(int Speed)
        {
            if (Speed <= 20)
            {
                CurrentSpeed = Speed;
                Restore();
            }
        }
        static void timerR_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (b >= 244)
            {
                r -= CurrentSpeed * 1;
                CurrentColor = Color.FromArgb(r, g, b);
                if (r <= 65)
                {
                    timerR.Stop();
                    timerG.Start();
                }
            }

            if (b <= 65)
            {
                r += CurrentSpeed * 1;
                CurrentColor = Color.FromArgb(r, g, b);
                if (r >= 244)
                {
                    timerR.Stop();
                    timerG.Start();
                }
            }
        }

        static void timerG_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (r <= 65)
            {
                g += CurrentSpeed * 1;
                CurrentColor = Color.FromArgb(r, g, b);
                if (g >= 244)
                {
                    timerG.Stop();
                    timerB.Start();
                }
            }

            if (r >= 244)
            {
                g -= CurrentSpeed * 1;
                CurrentColor = Color.FromArgb(r, g, b);
                if (g <= 65)
                {
                    timerG.Stop();
                    timerB.Start();
                }
            }
        }

        static void timerB_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (g <= 65)
            {
                b += CurrentSpeed * 1;
                CurrentColor = Color.FromArgb(r, g, b);
                if (b >= 244)
                {
                    timerB.Stop();
                    timerR.Start();
                }
            }

            if (g >= 244)
            {
                b -= CurrentSpeed * 1;
                CurrentColor = Color.FromArgb(r, g, b);
                if (b <= 64)
                {
                    timerB.Stop();
                    timerR.Start();
                }
            }
        }
    }
}
