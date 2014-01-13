using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
            : base(radius * 2, radius * 2)
        {
            this.Radius = radius;
        }

        public override double CalculateSurface()
        {
            double area = 0;
            area = Math.PI * this.Radius * this.Radius;

            return area;
        }

        public override string ToString()
        {
            string str = "Radius=" + this.Radius;

            return str;
        }
    }
}
