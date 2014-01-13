using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
            :base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double area = 0;
            area = (this.Width * this.Height) / 2;

            return area;
        }
    }
}
