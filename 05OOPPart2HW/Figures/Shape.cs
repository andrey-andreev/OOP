using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    public abstract class Shape
    {
        public double Width { get; protected set; }
        public double Height { get; protected set; }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        abstract public double CalculateSurface();

        public override string ToString()
        {
            string str = "Width=" + this.Width + ", Height=" + this.Height;

            return str;
        }
    }
}
