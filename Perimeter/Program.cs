using System;

namespace Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1 - Точка. Периметр полигона
            Point firstPoint = new Point(1, 1, "firstPoint");
            Point secondPoint = new Point(2, 2, "secondPoint");
            Point threePoint = new Point(3, 1, "threePoint");
            Point fourPoint = new Point(2, -10, "fourPoint");
            Point fivePoint = new Point(-5, -5, "fivePoint");


            Polygon test_polygon1 = new Polygon(firstPoint, secondPoint, threePoint);
            var p1 = test_polygon1.Perimeter();
            Console.WriteLine($"Периметр {test_polygon1.Name} = " + p1);


            Polygon test_polygon2 = new Polygon(firstPoint, secondPoint, threePoint, fourPoint);
            var p2 = test_polygon2.Perimeter();
            Console.WriteLine($"Периметр {test_polygon2.Name} = " + p2);

            Polygon test_polygon3 = new Polygon(firstPoint, secondPoint, threePoint, fourPoint, fivePoint);
            var p3 = test_polygon3.Perimeter();
            Console.WriteLine($"Периметр {test_polygon3.Name} = " + p3);


            Console.ReadLine();
        }
    }
}
