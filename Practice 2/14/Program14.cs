//using System;

//namespace Practice_2
//{
//    public class Program14
//    {
//        public static void Main()
//        {
//            int size = 5;
//            int[] arr = InitArray(size);
//            RandomArray(arr);
//            PrintArray(arr);

//            Console.ReadLine();
//        }
//        public static int[] InitArray(int size)
//        {
//            int[] arr = new int[size];

//            return arr;
//        }
//        public static int[] RandomArray(int[] arr)
//        {
//            Random random = new Random();
//            for (int i = 0; i < arr.Length; i++)
//                arr[i] = random.Next(1, 100);

//            return arr;
//        }
//        public static void PrintArray(int[]arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//                Console.WriteLine(arr[i]);
//        }
//    }
//}