using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Sphere sphere1 = new Sphere(new Color(255, 1, 1), 10.0, 0);
            Sphere sphere2 = new Sphere(new Color(1, 255, 1), 15.0, 0);
            Sphere sphere3 = new Sphere(new Color(1, 1, 255), 20.0, 0);
            
            for (int i = 0; i < 10; i++)
            {
                sphere1.Throw();
                sphere2.Throw();
                sphere3.Throw();
            }
            
            sphere2.Pop();

            Console.WriteLine($"Sphere 1 - Color: ({sphere1.Color}), Radius: {sphere1.Radius}, Times Thrown: " +
                              $"{sphere1.GetTimesThrown()}");

            Console.WriteLine($"Sphere 2 - Color: ({sphere2.Color}), Radius: Popped, Times Thrown: " +
                              $"{sphere3.GetTimesThrown()}");

            Console.WriteLine($"Sphere 3 - Color: ({sphere3.Color}), Radius: {sphere3.Radius}, Times Thrown: " +
                              $"{sphere3.GetTimesThrown()}");
        }
    }
}
