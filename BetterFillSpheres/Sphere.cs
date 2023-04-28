namespace BetterFillSpheres
{
    public class Sphere
    {
        private const int DefaultTimesThrown = 0;

        private Color Color { get; }
        private double Radius { get; set; }
        private int TimesThrown { get; set; }

        public Sphere(Color color, double radius)
        {
            Color = color;
            Radius = radius;
            TimesThrown = DefaultTimesThrown;
        }

        public void Pop()
        {
            Radius = 0;
        }

        public void Throw()
        {
            if (Radius > 0)
            {
                TimesThrown++;
            }
        }
    }
}