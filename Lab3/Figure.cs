using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Figure
    {
        Point[] points;
        public string Name { get => $"{points.Length}-кутник"; }
        public Figure(params Point[] points)
        {
            if (points.Length >= 3 && points.Length <= 5)
            {
                this.points = points;
            }
                
            else throw new ArgumentOutOfRangeException("Requires 3 to 5 points");
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            perimeter += LengthSide(points[points.Length - 1], points[0]);
            return perimeter;
        }
    }
}
