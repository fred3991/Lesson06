using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Ball : Shape
    {
        public override string Name => "Шарик";

        private double _radius;
        public double Radius { get => _radius; set => _radius = value; }

        public Ball(double radius)
        {
            _radius = radius;
        }
        /// <summary>
        /// Обьем Шара
        /// </summary>
        /// <returns></returns>
        public override double Volume()
        {
            return (4.0 / 3.0) * Math.PI * (Math.Pow(_radius, 3)); // возвращает обьем фигуры
        }
    }
}
