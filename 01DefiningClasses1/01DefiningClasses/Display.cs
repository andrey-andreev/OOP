using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DefiningClasses
{
    public class Display
    {
        //fields
        private double? size;
        private int? colorsNumber;
        //properties
        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (this.size < 0)
                {
                    throw new ArgumentOutOfRangeException("The size cannot be negatine number.");
                }
                else
                {
                    this.size = value;
                }
            }
        }
        public int? ColorsNumber
        {
            get
            {
                return this.colorsNumber;
            }
            set
            {
                if (this.colorsNumber < 0)
                {
                    throw new ArgumentOutOfRangeException("The colors number cannot be negative number.");
                }
                else
                {
                    this.colorsNumber = value;
                }
            }
        }
        //c-tors
        public Display()
        {
            this.Size = null;
            this.ColorsNumber = null;
        }

        public Display(double? size, int? colorNumber)
        {
            this.Size = size;
            this.ColorsNumber = colorNumber;
        }
    }
}
