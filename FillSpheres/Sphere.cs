namespace FillSpheres
{
    public class Sphere
    {
        private Color _color;
        private double _radius;
        private int _timesThrown;

        public Sphere(Color color, double radius, int timesThrown)
        {
            _color = color;
            _radius = radius;
            _timesThrown = timesThrown;
        }
        
        public void Pop()
        {
            _radius = 0;
        }

        public void Throw()
        {
            if (_radius > 0)
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