/*using System;

namespace Practice_2
{
    class ProgramNine
    {
        static void Main()
        {
            int[] arr = InitArray(5);
            PrintArray(arr);
            Console.ReadKey();
        }
        static int[] InitArray(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
                arr[i] = i + 12;
            return arr;
        }
        static void PrintArray(int[]arr)
        {
            string output = "";
            for (int i = 0; i < arr.Length; i++)
                output += arr[i].ToString() + " ";

            Console.WriteLine(output);
        }
    }
}*/