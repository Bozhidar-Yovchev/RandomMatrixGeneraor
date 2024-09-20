using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixDiagonals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter columns:");
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            Console.WriteLine("Ennter the elements of the matrix");
            AddElements(matrix);

            Console.WriteLine(PrintMatrix(matrix, " "));
            Console.WriteLine("The sum of all elements is: {0}", SumAll(rows, columns, matrix));
            Console.WriteLine("The sum of the elements over the mai diagonal is: {0}", SumOverMainDiagonal(rows, columns, matrix));
            Console.WriteLine("The sum of the elements under the main diagonal is: {0}", SumUnderMainDiagonal(rows, matrix));
        }

        private static int SumUnderMainDiagonal(int rows, int[,] A)
        {
            int S2 = 0;
            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    S2 += A[i, j];
                }
            }
            return S2;
        }

        private static int SumOverMainDiagonal(int rows, int columns, int[,] A)
        {
            int S1 = 0;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < columns; j++)
                {
                    S1 += A[i, j];
                }
            }

            return S1;
        }

        private static int SumAll(int rows, int columns, int[,] A)
        {
            int S = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    S += A[i, j];
                }
            }

            return S;
        }

        private static void AddElements(int[,] A)
        {

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        private static string PrintMatrix(int[,] matrix, string separator)
        {
            string result = string.Empty;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int count = 0;
                    int currentItem = matrix[i, j];
                    int times = 4;

                    if (j == matrix.GetLength(1) - 1)
                    {
                        result += matrix[i, j];
                    }
                    else
                    {
                        for (int k = 0; currentItem != 0; k++)
                        {
                            currentItem /= 10;
                            count++;

                        }
                        result += matrix[i, j];
                        switch (count)
                        {
                            case 1:
                                times = 3;
                                break;
                            case 2:
                                times = 2;
                                break;
                            case 3:
                                times = 1;
                                break;
                        }

                        for (int n = 0; n < times; n++)
                        {
                            result += separator;
                        }
                    }
                }
                result += Environment.NewLine;
            }
            return result;
        }
    }
}
