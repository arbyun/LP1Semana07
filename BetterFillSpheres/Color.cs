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
        
        public string Name
        {
            get
            {
                switch (ToString())
                {
                    case "#FF000000":
                        return "Red 100%";
                    case "#00FF00FF":
                        return "Green 100%";
                    case "#0000FFFF":
                        return "Blue 100%";
                    default:
                        return "Mixed";
                }
            }
        }

        public Color(int red, int green, int blue, int alpha)
        {
            Red = ValidateColorComponent(red);
            Green = ValidateColorComponent(green);
            Blue = ValidateColorComponent(blue);
            Alpha = ValidateColorComponent(alpha);
        }

        private static int ValidateColorComponent(int value) => Math.Min(Math.Max(value, MinValue), MaxValue);
        
        public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

        public int GetGrey()
        {
            return (Red + Green + Blue) / 3;
        }
        
        public override string ToString()
        {
            return $"#{Red:X2}{Green:X2}{Blue:X2}{Alpha:X2}";
        }
    }
}