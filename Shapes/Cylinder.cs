using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cylinder : Shape
    {
        private double _radius;
        private double _height;

        public double Radius { get => _radius; set => _radius = value; }
        public double Height { get => _height; set => _height = value; }

        public override string Name => "Цилиндр";

        public Cylinder(double radius, double height)
        {
            _radius = radius;
            _height = height;
        }
        /// <summary>
        /// Обьем цилиндра
        /// </summary>
        /// <returns></returns>
        public override double Volume()
        {
            return Math.PI * _radius * _radius * _height; // возвращает обьем фигуры
        }
    }
}
