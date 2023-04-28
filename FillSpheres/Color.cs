namespace FillSpheres
{
    public class Color
    {
        private readonly int _red;
        private readonly int _green;
        private readonly int _blue;
        private int _alpha;
        
        public Color(int red, int green, int blue, int alpha)
        {
            _green = green;
            _blue = blue;
            _alpha = alpha;
            _red = red;
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