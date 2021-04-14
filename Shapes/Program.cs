using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем обьемные фигуры
            Ball ball1 = new Ball(1);
            Ball ball2 = new Ball(2);
            Ball ball3 = new Ball(3);

            Pyramid pyr1 = new Pyramid(1, 1);
            Pyramid pyr2 = new Pyramid(2, 2);
            Pyramid pyr3 = new Pyramid(3, 3);

            Cylinder cyl1 = new Cylinder(1, 1);
            Cylinder cyl2 = new Cylinder(2, 2);
            Cylinder cyl3 = new Cylinder(3, 3);

            Console.WriteLine($"--------------------------------------------------------------------------");
            Console.WriteLine($"Создаем 9 фигур");
            Console.WriteLine($"3 шара с обьемом  - {ball1.Volume()}, {ball2.Volume()}, {ball3.Volume()} ");
            Console.WriteLine($"--------------------------------------------------------------------------");
            Console.WriteLine($"3 пирамиды с обьемом  - {pyr1.Volume()}, {pyr2.Volume()}, {pyr3.Volume()} ");
            Console.WriteLine($"--------------------------------------------------------------------------");
            Console.WriteLine($"3 цилиндра с обьемом - {cyl1.Volume()}, {cyl2.Volume()}, {cyl3.Volume()} ");


            Console.WriteLine($"--------------------------------------------------------------------------");
            Box box = new Box(6);

            Console.WriteLine($"Создали коробку с ребрами {box.Height}");
            Console.WriteLine($"--------------------------------------------------------------------------");

            List<Shape> shapeList = new List<Shape> { ball1, ball2, ball3, pyr1, pyr2, pyr3, cyl1, cyl2, cyl3 };


            Console.WriteLine($"Закидываем все фигуры в коробку и смотрим, залезли ли они туда?");

            bool loadNext = true;

            foreach (Shape sh in shapeList)
            {
                if (loadNext == box.Add(sh))
                {
                    Console.WriteLine($"--------------------------------------------------------------------------");
                    Console.WriteLine($"Предмет {sh.Name} c обьемом {sh.Volume()} Успешно положили в коробку! ");
                    Console.WriteLine($"В Коробке осталось {box.BoxFreeSpace()} пустого места!");
                    Console.WriteLine($"--------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine($"--------------------------------------------------------------------------");
                    Console.WriteLine($"В Коробке не хватает места для {sh.Name}, она обьемом {sh.Volume()}! А в коробке осталось только  {box.BoxFreeSpace()}!");
                    Console.WriteLine($"--------------------------------------------------------------------------");
                }


            }

            Console.WriteLine($"--------------Конец----------------");
            Console.ReadLine();
        }
    }
}
