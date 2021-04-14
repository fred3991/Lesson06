using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter
{
    public class Point
    {
        // только для чтения
        private int x;
        public int X
        {
            get { return x; }
            private set { x = value; }
        }

        private int y;
        public int Y
        {
            get { return y; }
            private set { y = value; }
        }
        public string PointName { get; }
        public Point(int xCor, int yCor, string pName) //Конструктор
        {
            X = xCor;
            Y = yCor;
            PointName = pName;
        }
    }
}
