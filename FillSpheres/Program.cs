using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Sphere sphere1 = new Sphere(new Color(255, 0, 0), 10.0, 0);
            Sphere sphere2 = new Sphere(new Color(0, 255, 0), 15.0, 0);
            Sphere sphere3 = new Sphere(new Color(0, 0, 255), 20.0, 0);
            
            for (int i = 0; i < 10; i++)
            {
                sphere1.Throw();
                sphere2.Throw();
                sphere3.Throw();
            }
        }
    }
}
