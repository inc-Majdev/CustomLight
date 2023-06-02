using System;
using System.Drawing;
using System.Threading;

public enum ColorAnimationMode
{
    Rainbow,
    RandomColor,
    RandomFlash,
    ColorFlash,
    RandomBreathing,
    ColorBreathing
}

public class ColorAnimationGenerator
{
    private Thread animationThread;
    private bool isRunning;
    private Color currentColor;
    private Random random;
    private int animationSpeed;
    private int updateInterval;
    private ColorAnimationMode colorAnimationMode;
    private Color customColor;

    public event EventHandler<ColorChangedEventArgs> ColorChanged;

    public ColorAnimationGenerator()
    {
        random = new Random();
    }

    public void StartAnimation(ColorAnimationMode mode, Color color, int initialAnimationSpeed)
    {
        if (animationThread != null)
        {
            try
            {
                animationThread.Abort();
                animationThread = null;
            }
            catch { }
        }

        animationSpeed = initialAnimationSpeed;
        colorAnimationMode = mode;
        customColor = color;
        updateInterval = CalculateUpdateInterval(animationSpeed);
        isRunning = true;
        animationThread = new Thread(() => AnimationThread(mode));
        animationThread.Start();
    }

    public void SetAnimationSpeed(int newAnimationSpeed)
    {
        if (isRunning)
        {
            animationSpeed = newAnimationSpeed;
            updateInterval = CalculateUpdateInterval(animationSpeed);
        }
    }

    public void SetCustomColor(Color customColor)
    {
        StartAnimation(colorAnimationMode, customColor, animationSpeed);
    }

    private void AnimationThread(ColorAnimationMode mode)
    {
        while (isRunning)
        {
            Color newColor = Color.Black;

            switch (mode)
            {
                case ColorAnimationMode.Rainbow:
                    newColor = GetNextRainbowColor();
                    break;
                case ColorAnimationMode.RandomColor:
                    newColor = GetRandomColor();
                    break;
                case ColorAnimationMode.RandomFlash:
                    newColor = currentColor == Color.Black ? GetRandomColor() : Color.Black;
                    break;
                case ColorAnimationMode.ColorFlash:
                    newColor = currentColor == Color.Black ? this.customColor : Color.Black;
                    break;
                case ColorAnimationMode.RandomBreathing:
                    newColor = ColorBreathingAnimation(GetRandomColor());
                    break;
                case ColorAnimationMode.ColorBreathing:
                    newColor = ColorBreathingAnimation(this.customColor);
                    break;
            }

            if (currentColor != newColor)
            {
                currentColor = newColor;
                OnColorChanged(currentColor);
            }

            Thread.Sleep(updateInterval);
        }
    }

    private Color GetNextRainbowColor()
    {
        int r = (int)(Math.Sin(animationSpeed * 0.01745) * 127 + 128);
        int g = (int)(Math.Sin((animationSpeed + 120) * 0.01745) * 127 + 128);
        int b = (int)(Math.Sin((animationSpeed + 240) * 0.01745) * 127 + 128);
        animationSpeed += 5;
        return Color.FromArgb(255, r, g, b);
    }

    private Color GetRandomColor()
    {
        return Color.FromArgb(
            255,
            random.Next(256),
            random.Next(256),
            random.Next(256));
    }

    private Color ColorBreathingAnimation(Color flashColor)
    {
        double factor = (Math.Sin(DateTime.Now.Millisecond / 1000.0 * 2 * Math.PI) + 1) / 2;
        int r = (int)(flashColor.R * factor);
        int g = (int)(flashColor.G * factor);
        int b = (int)(flashColor.B * factor);
        return Color.FromArgb(255, r, g, b);
    }

    private void OnColorChanged(Color color)
    {
        ColorChangedEventArgs args = new ColorChangedEventArgs(color);
        ColorChanged?.Invoke(this, args);
    }

    private int CalculateUpdateInterval(int speed)
    {
        if (colorAnimationMode == ColorAnimationMode.Rainbow)
        {
            if (speed == 1)
            {
                return 600;
            }
            if (speed == 2)
            {
                return 100;
            }
            if (speed == 3)
            {
                return 1;
            }
        }

        if (colorAnimationMode == ColorAnimationMode.RandomBreathing || colorAnimationMode == ColorAnimationMode.ColorBreathing)
        {
            if (speed == 1)
            {
                return 300;
            }
            if (speed == 2)
            {
                return 200;
            }
            if (speed == 3)
            {
                return 100;
            }
        }

        if (speed == 1)
        {
            return 1000;
        }
        if (speed == 2)
        {
            return 500;
        }
        if (speed == 3)
        {
            return 100;
        }
        return 1000;
    }
}

public class ColorChangedEventArgs : EventArgs
{
    public Color NewColor { get; private set; }

    public ColorChangedEventArgs(Color newColor)
    {
        NewColor = newColor;
    }
}
