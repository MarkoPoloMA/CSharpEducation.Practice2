/*using System;

namespace Practice_2
{
    class Program13
    {
        static void Main()
        {
            int rows = 3; // количество строк
            int cols = 4; // количество столбцов
            int[,] arr = CreateArray(rows, cols);
            PrintArray(arr);

            Console.ReadKey();
        }

        static int[,] CreateArray(int rows, int cols)
        {
            Random random = new Random();
            int[,] arr = new int[rows, cols];   

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    arr[i, j] = random.Next(1, 100); 
            }
            return arr;
        }
        static void PrintArray(int[,]arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + "   ");
                Console.WriteLine();
            }
        }
    }
}*/