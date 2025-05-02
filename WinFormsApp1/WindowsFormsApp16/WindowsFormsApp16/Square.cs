using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    internal class Square : IShape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
        public double Area()
        {
            return Side * Side;
        }
        public string GetShapeInfo()
        {
            return $"квадрат со стороной {Side},площадь: {Area()}";
        }
    }
}
