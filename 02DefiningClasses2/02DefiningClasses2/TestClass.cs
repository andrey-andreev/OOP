using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidian3DSpace
{
    class TestClass
    {
        static void Main(string[] args)
        {
            //testing 1. 2. 3.
            Point3D p1 = new Point3D(25, 13, 15);
            Point3D p2 = new Point3D(-35, 18, 1);
            Point3D p3 = new Point3D(65, 12, -45);
            Console.WriteLine(Operations.CalculateDistance(p1, p2));

            //testing 4.
            Path path1 = new Path();
            path1.Sequence.Add(p1);
            path1.Sequence.Add(p2);
            Console.WriteLine();

            foreach (var point in path1.Sequence)
            {
                Console.WriteLine(point.ToString());
            }
            Console.WriteLine();

            PathStorage.Save(path1);
            Path path2 = new Path();
            path2 = PathStorage.Load();

            foreach (var point in path2.Sequence)
            {
                Console.WriteLine(point.ToString());
            }
            
            
        }
    }
}
