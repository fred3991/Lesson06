using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    // <summary>
    /// Класс коробка,
    /// имеет обьем, и список того что внутри.
    /// Имеет метод Add (Shape shape) - который выдает true если можно поместить внутрь еще один обьект
    /// или False если обьем будет превышен
    // </summary>
    // 
    public class Box : Shape
    {
        //Название коробки
        public override string Name => "Коробка";
        //Высота коробки для расчет обьема
        private double _height;
        public double Height { get => _height; set => _height = value; }
        //Лист обьектов - то что внутри коробки
        //свойство
        public List<Shape> ShapeList { get; } = new List<Shape>();


        //поле - свободное место в коробке
        private double _boxFreeSpace;
        public Box(double H)
        {
            _height = H;
        }

        //Обьем коробки
        public override double Volume()
        {
            return Math.Pow(_height, 3); // Возвращает обьем коробки
        }

        public double BoxFreeSpace()
        {

            return Volume() - _boxFreeSpace;
        }

        public bool Add(Shape shape)
        {
            bool emptyspace;

            double boxFreespace = BoxFreeSpace();
            double shapeVolume = shape.Volume();

            if (boxFreespace >= shapeVolume)
            {
                ShapeList.Add(shape);
                _boxFreeSpace += shapeVolume;
                emptyspace = true;
            }
            else
            {
                emptyspace = false;
            }

            return emptyspace;
        }

    }
}
