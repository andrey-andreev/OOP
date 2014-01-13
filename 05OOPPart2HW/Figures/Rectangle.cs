using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            :base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double area = 0;
            area = this.Width * this.Height;

            return area;
        }
    }
}
