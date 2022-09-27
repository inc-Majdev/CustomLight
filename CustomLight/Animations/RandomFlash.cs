using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CustomLight.Animations
{
    internal class RandomFlash
    {
        static Timer Animation;
        public static int CurrentSpeed = 5;
        public static Color CurrentColor;
        public static void Setup()
        {
            if(CurrentSpeed <= 0)
            {
                CurrentSpeed = 1;
            }
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

        static void Animation_Elapsed(object sender, ElapsedEventArgs e)
        {
            Random Random = new Random();
            int RandomR = Random.Next(0, 255);
            int RandomG = Random.Next(0, 255);
            int RandomB = Random.Next(0, 255);
            CurrentColor = Color.FromArgb(RandomR, RandomG, RandomB);
            System.Threading.Thread.Sleep(100);
            CurrentColor = Color.FromArgb(0, 0, 0);
        }
    }
}
