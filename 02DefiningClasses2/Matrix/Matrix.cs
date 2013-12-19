
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<K>
        where K : struct, IComparable, IFormattable, IConvertible, IComparable<K>, IEquatable<K>
    {
        private K[,] matrix;
        public int Cols { get; private set; }
        public int Rows { get; private set; }
        

	    public K this[int rowIndex, int colIndex]
	    {
		    get 
            { 
                return this.matrix[rowIndex, colIndex];
            }
		    set 
            {
                this.matrix[rowIndex, colIndex] = value;
            }
	    }
	

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new K[rows, cols];
        }

        public static Matrix<K> operator +(Matrix<K> matrix1, Matrix<K> matrix2)
        {
            if (matrix1.Cols == matrix2.Cols && matrix1.Rows == matrix2.Rows)
            {
                Matrix<K> resultMatrix = new Matrix<K>(matrix1.Rows, matrix1.Cols);
                for (int row = 0; row < matrix1.Rows; row++)
                {
                    for (int col = 0; col < matrix1.Cols; col++)
                    {
                        resultMatrix[row, col] = (dynamic)matrix1[row, col] + (dynamic)matrix2[row, col];
                    }
                }

                return resultMatrix;
            }
            else
            {
                throw new ArgumentException("The matrixes isn't same size!");
            }
        }

        public static Matrix<K> operator -(Matrix<K> matrix1, Matrix<K> matrix2)
        {
            if (matrix1.Cols == matrix2.Cols && matrix1.Rows == matrix2.Rows)
            {
                Matrix<K> resultMatrix = new Matrix<K>(matrix1.Rows, matrix1.Cols);
                for (int row = 0; row < matrix1.Rows; row++)
                {
                    for (int col = 0; col < matrix1.Cols; col++)
                    {
                        resultMatrix[row, col] = (dynamic)matrix1[row, col] - (dynamic)matrix2[row, col];
                    }
                }

                return resultMatrix;
            }
            else
            {
                throw new ArgumentException("The matrixes isn't same size!");
            }
        }

        public static Matrix<K> operator *(Matrix<K> matrix1, Matrix<K> matrix2)
        {
            
            if (matrix1.Cols == matrix2.Rows)
            {
                Matrix<K> resultMatrix = new Matrix<K>(matrix1.Rows, matrix2.Cols);
                for (int a = 0; a < resultMatrix.Rows; a++)
                {
                    for (int b = 0; b < resultMatrix.Cols; b++)
                    {
                        for (int c = 0; c < matrix1.Cols; c++)
                        {
                            resultMatrix[a, b] += (dynamic)matrix1[a, c] * (dynamic)matrix2[c, b];
                        }
                    }
                }
                
                return resultMatrix;
            }
            else
            {
                throw new ArgumentException("First matrix columns isn't same number as second matrix rows!");
            }

        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    result.Append(this.matrix[row, col]);
                    if (col < this.matrix.GetLength(1) - 1)
                    {
                        result.Append(" ");
                    }
                }
                result.AppendLine();
            }
            return result.ToString();
        }

        public static bool operator true(Matrix<K> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<K> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}