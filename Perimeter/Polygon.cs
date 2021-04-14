using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter
{
    public class Polygon
    {
        //
        private List<Point> _points;
        public string Name { get; }

        public Polygon(Point _point1, Point _point2, Point _point3) //конструктор на 3 точки
        {
            _points = new List<Point> { _point1, _point2, _point3 };
            Name = "Треугольник";
        }
        public Polygon(Point _point1, Point _point2, Point _point3, Point _point4) //конструктор на 4 точки
        {
            _points = new List<Point> { _point1, _point2, _point3, _point4 };
            Name = "Четырехугольник";
        }
        public Polygon(Point _point1, Point _point2, Point _point3, Point _point4, Point _point5) //конструктор на 5 точек
        {
            _points = new List<Point> { _point1, _point2, _point3, _point4, _point5 };
            Name = "Пятиугольник";
        }



        public double Perimeter() //Метод для расчета периметра многоугольника
        {
            double perimeterValue; // инициализируем переменную

            int pointCount = _points.Count; // количество точек

            List<double> lenghtArray = new List<double>(); // массив с длинами точек

            // расчитываем длину от 1 до 2 точки...

            double d, lastLenght;

            for (int i = 0; i < pointCount - 1; i++) // считаем длины сторон многоугольника с первой до последней
            {
                d = Math.Sqrt(Math.Pow((_points[i + 1].X - _points[i].X), 2) + Math.Pow((_points[i + 1].Y - _points[i].Y), 2));
                lenghtArray.Add(d);
            }
            //Считаем первую и последнюю точку
            lastLenght = Math.Sqrt(Math.Pow((_points[pointCount - 1].X - _points[0].X), 2) + Math.Pow((_points[pointCount - 1].Y - _points[0].Y), 2));

            lenghtArray.Add(lastLenght);
            perimeterValue = lenghtArray.Sum();
            return perimeterValue;
        }
    }
}
