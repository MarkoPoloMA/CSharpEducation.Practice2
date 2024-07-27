using System;

namespace Practice_2
{
    class Program20
    {
        public static void Main()
        {
            int[,] arr = CreateRandomArray(5, 7); 
            //PrintArray(arr);
            FindDifferenceInRows(arr);

            Console.ReadKey();
        }
        static int[,] CreateRandomArray(int rows, int cols)
        {
            Random random = new Random();
            int[,] arr = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = random.Next(1, 101);
                }
            }
            return arr;
        }
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + " ");
               
                Console.WriteLine();
        }
        static void FindDifferenceInRows(int[,] array)
        { 
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int max = array[i, 0];
                int min = array[i, 0];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max) max = array[i, j];
                    if (array[i, j] < min) min = array[i, j];
                }
                int diff = max - min;
                Console.WriteLine(diff);
            }
        }


    }
}
