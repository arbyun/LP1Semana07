namespace FillSpheres
{
    public class Sphere
    {
        internal readonly Color Color;
        internal double Radius;
        private int _timesThrown;
        public const int DefaultTimesThrown = 0;

        public Sphere(Color color, double radius)
        {
            Color = color;
            Radius = radius;
            _timesThrown = DefaultTimesThrown;
        }
        
        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
            {
                _timesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return _timesThrown;
        }
    }
}