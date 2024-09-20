using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter columns");
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            InputRandomMatrix(matrix);
            Console.WriteLine(PrintMatrix(matrix, " "));
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

        private static int[,] InputRandomMatrix(int[,] matrix)
        {
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(0, 100);
                }
            }
            return matrix;
        }
    }
}
