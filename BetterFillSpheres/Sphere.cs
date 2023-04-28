namespace BetterFillSpheres
{
    public class Sphere
    {
        private const int DefaultTimesThrown = 0;

        internal Color Color { get; }
        internal double Radius { get; set; }
        internal int TimesThrown { get; set; }

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