using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Point
    {
        int x, y;
        
        public int X { get => x; }
        public int Y { get => y; }
        public Point (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
