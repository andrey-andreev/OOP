using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidian3DSpace
{
    public struct Point3D
    {
        // 1.
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        // 2.
        private static readonly Point3D startPoint = new Point3D(0, 0, 0);

        public Point3D StartPoint
        {
            get 
            { 
                return this.StartPoint; 
            }
        }

        public Point3D(int x, int y, int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        // 1.
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.X + " " + this.Y + " " + this.Z);

            string printInfo = result.ToString();

            return printInfo;
        }
    }
}
