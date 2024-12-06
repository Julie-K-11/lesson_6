using lesson_6.Task_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_6.Task_2
{
    public class Matrix
    {
        private int[,] elements { get; set; }

        public int Rows => elements.GetLength(0);
        public int Columns => elements.GetLength(1);

        public Matrix(int rows, int columns)
        {
            elements = new int[rows, columns];
        }

        public int this[int row, int column]
        {
            get => elements[row, column];
            set => elements[row, column] = value;
        }

        public void InputData()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"Введіть елемент [{i},{j}]: ");
                    elements[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void DisplayData()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(elements[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int FindMax()
        {
            int max = elements[0, 0];
            foreach (var item in elements)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        public int FindMin()
        {
            int min = elements[0, 0];
            foreach (var item in elements)
            {
                if (item < min)
                    min = item;
            }
            return min;
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                throw new InvalidOperationException("Розміри матриць мають співпадати.");

            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                throw new InvalidOperationException("Розміри матриць мають співпадати.");

            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                throw new InvalidOperationException("Розміри матриць мають співпадати.");

            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix matrix1, int scalar)
        {
            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    result[i, j] = matrix1[i, j] * scalar;
                }
            }
            return result;
        }

        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
                return false;

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                        return false;
                }
            }
            return true;
        }

        public static bool operator !=(Matrix matrix1, Matrix matrix2) => !(matrix1 == matrix2);

        public bool Equals(Matrix anotherMatrix)
        {
            if (anotherMatrix == null) return false;
            if (this.elements.GetLength(0) != anotherMatrix.elements.GetLength(0) ||
                this.elements.GetLength(1) != anotherMatrix.elements.GetLength(1)) return false;

            for (int i = 0; i < this.elements.GetLength(0); i++)
            {
                for (int j = 0; j < this.elements.GetLength(1); j++)
                {
                    if (this.elements[i, j] != anotherMatrix.elements[i, j]) return false;
                }
            }
            return true;
        }


        public override bool Equals(object obj)
        {
            if (obj is Matrix other)
            {
                return this == other;
            }
            return false;
        }

         public override string ToString()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    builder.Append(elements[i, j] + " ");
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }
    }
}
