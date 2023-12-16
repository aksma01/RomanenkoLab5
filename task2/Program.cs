using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class MathOperations
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int[] Add(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                throw new ArgumentException("Arrays must have the same length");
            }

            int[] result = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] + array2[i];
            }

            return result;
        }

        public static int[,] Add(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                throw new ArgumentException("Matrices must have the same dimensions");
            }

            int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            int sum = MathOperations.Add(5, 3);
            Console.WriteLine($"Sum of numbers: {sum}");

            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] arraySum = MathOperations.Add(array1, array2);
            Console.WriteLine($"Sum of arrays: [{string.Join(", ", arraySum)}]");

            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
            int[,] matrixSum = MathOperations.Add(matrix1, matrix2);
            Console.WriteLine("Sum of matrices:");
            for (int i = 0; i < matrixSum.GetLength(0); i++)
            {
                for (int j = 0; j < matrixSum.GetLength(1); j++)
                {
                    Console.Write($"{matrixSum[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
