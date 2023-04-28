using System;

namespace BetterFillSpheres
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Color red = new Color(255, 0, 0, 0);
            Color green = new Color(0, 255, 0, 255);
            Color blue = new Color(0, 0, 255, 255);
            Color mixed = new Color(128, 128, 128, 255);
            Sphere sphere1 = new Sphere(red, 10);
            Sphere sphere2 = new Sphere(green, 5);

            sphere1.Throw();
            sphere1.Throw();
            sphere1.Pop();
            sphere2.Throw();

            Console.WriteLine($"Sphere 1: color={sphere1.Color.GetGrey()}, radius={sphere1.Radius}, " +
                              $"times thrown={sphere1.TimesThrown}");
            Console.WriteLine($"Sphere 2: color={sphere2.Color.GetGrey()}, radius={sphere2.Radius}, " +
                              $"times thrown={sphere2.TimesThrown}");
            
            Console.WriteLine(red.Name);
            Console.WriteLine(green.Name);
            Console.WriteLine(blue.Name);
            Console.WriteLine(mixed.Name);
        }
    }
}
