using System;

namespace FillSpheres
{
    public class Color
    {
        private const int MinValue = 0;
        private const int MaxValue = 255;
        
        private readonly int _red;
        private readonly int _green;
        private readonly int _blue;
        private int _alpha;
        
        private int ValidateColorComponent(int value)
        {
            return Math.Min(Math.Max(value, MinValue), MaxValue);
        }

        private Color(int red, int green, int blue, int alpha)
        {
            _green = ValidateColorComponent(green);
            _blue = ValidateColorComponent(blue);
            _alpha = ValidateColorComponent(alpha);
            _red = ValidateColorComponent(red);
        }
        
        public Color(int red, int green, int blue) : this(red, green, blue, 255)
        {
        }
        
        public int Red { get; set; }
        
        public int Green { get; set; }

        public int Blue { get; set; }

        public int Alpha { get; set; }

        public int GetGrey() => _red + _green + _blue / 3;
    }
}