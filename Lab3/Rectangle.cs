using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Rectangle
    {
        public double side1, side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double CalculateArea()
        {
            return side1 * side2;
        }
        public double CalculatePerimeter()
        {
            return 2 * (side1 + side2);
        }
    }
}
