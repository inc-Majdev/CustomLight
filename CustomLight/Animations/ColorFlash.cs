using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Clevo;

namespace CustomLight.Animations
{
    internal class ColorFlash
    {
        static Timer Animation;
        public static int CurrentSpeed = 5;
        public static Color CurrentColor;
        public static Color OldColor;
        public static void Setup(Color color)
        {
            if (CurrentSpeed <= 0)
            {
                CurrentSpeed = 1;
            }
            OldColor = color;
            var Temptimer = new Timer(1000 / CurrentSpeed);
            Temptimer.Elapsed += new ElapsedEventHandler(Animation_Elapsed);
            Temptimer.Enabled = false;
            Temptimer.Start();
            Animation = Temptimer;
        }

        static void Restore()
        {
            Animation.Stop();
            Animation = null;
            CurrentColor = Color.Empty;
            Setup(OldColor);
        }

        public static void SetSpeed(int Speed)
        {
            if (Speed <= 20)
            {
                CurrentSpeed = Speed;
                Restore();
            }
        }

        static void Animation_Elapsed(object sender, ElapsedEventArgs e)
        {
            CurrentColor = OldColor;
            System.Threading.Thread.Sleep(100);
            CurrentColor = Color.FromArgb(0, 0, 0);
        }
    }
}
