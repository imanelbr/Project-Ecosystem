using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ecosystem
{
    public class DrawObject
    {
        Color color;
        double x, y;
        public DrawObject(Color color, double x, double y)
        {
            this.color = color;
            this.x = x;
            this.y = y;
        }

        public Color Color { get { return this.color; } }
        public double X { get { return this.x; } set { this.x = value; } }
        public double Y { get { return this.y; } }
    }
}
