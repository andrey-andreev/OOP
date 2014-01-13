using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle testRectanle = new Rectangle(15.345, 45.936);
            Console.WriteLine(testRectanle);
            Console.WriteLine(testRectanle.CalculateSurface());

            Triangle testTriangle = new Triangle(34.65, 19.73);
            Console.WriteLine(testTriangle);
            Console.WriteLine(testTriangle.CalculateSurface());

            Circle testCircle = new Circle(34.56);
            Console.WriteLine(testCircle);
            Console.WriteLine(testCircle.CalculateSurface());
        }
    }
}
