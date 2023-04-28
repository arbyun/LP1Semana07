using System;

namespace BetterFillSpheres
{
    public class Color
    {
        private const int MinValue = 0;
        private const int MaxValue = 255;

        private int Red { get; }
        private int Green { get; }
        private int Blue { get; }

        private int Alpha { get; }

        public Color(int red, int green, int blue, int alpha)
        {
            Red = ValidateColorComponent(red);
            Green = ValidateColorComponent(green);
            Blue = ValidateColorComponent(blue);
            Alpha = ValidateColorComponent(alpha);
        }

        private static int ValidateColorComponent(int value) => Math.Min(Math.Max(value, MinValue), MaxValue);

        public int GetGrey()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}