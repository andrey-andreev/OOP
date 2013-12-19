using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidian3DSpace
{
    //4.
    public class Path
    {
        public List<Point3D> Sequence { get; set; }

        public Path()
        {            
            this.Sequence = new List<Point3D>();
        }
    }
}
