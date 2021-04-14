using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Pyramid : Shape
    {
        public override string Name => "Пирамида";

        private double _area;
        private double _height;

        public double Area { get => _area; set => _area = value; }
        public double Height { get => _height; set => _height = value; }

        public Pyramid(double area, double height)
        {
            _area = area;
            _height = height;
        }
        /// <summary>
        /// Вычисляет обьем Пирамиды
        /// </summary>
        /// <returns></returns>
        public override double Volume()
        {
            return (_area * _height) / 3.0; // возвращает обьем фигуры
        }
    }
}
