namespace FillSpheres
{
    public class Sphere
    {
        internal Color Color;
        internal double Radius;
        private int _timesThrown;

        public Sphere(Color color, double radius, int timesThrown)
        {
            Color = color;
            Radius = radius;
            _timesThrown = timesThrown;
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