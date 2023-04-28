namespace FillSpheres
{
    public class Color
    {
        private int _red;
        private int _green;
        private int _blue;
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
    }
}