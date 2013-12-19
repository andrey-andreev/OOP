using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Test
    {
        static void Main(string[] args)
        {
            Matrix<int> testMatrix1 = new Matrix<int>(2, 3);
            int addend = 0;
            for (int row = 0; row < testMatrix1.Rows; row++)
            {
                for (int col = 0; col < testMatrix1.Cols; col++)
                {
                    addend++;
                    testMatrix1[row, col] = addend;
                }
            }
            Matrix<int> testMatrix2 = testMatrix1;
            Matrix<int> testMatrix3 = new Matrix<int>(3, 2);
            for (int row = 0; row < testMatrix3.Rows; row++)
            {
                for (int col = 0; col < testMatrix3.Cols; col++)
                {
                    addend++;
                    testMatrix3[row, col] = addend;
                }
            }

            Console.WriteLine("First and second matrix : \n" + testMatrix1.ToString());
            Console.WriteLine("Trird matrix : \n" + testMatrix3.ToString());
            Console.WriteLine("Addition : \n" + (testMatrix1 + testMatrix2).ToString());
            Console.WriteLine("Subtraction : \n" + (testMatrix1 - testMatrix2).ToString());
            Console.WriteLine("Multiplication : \n" + (testMatrix1 * testMatrix3).ToString());

            //check for non-zero elements
            if (testMatrix1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            testMatrix1[1, 2] = 0;

            if (testMatrix1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
