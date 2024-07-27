//using System;

//namespace Practice_2
//{
//    public class Program15
//    {
//        public static void Main() {
//            int[] arr = { 1, 3, 5, 7, 8 };
//            int[] newArr = ReverseArray(arr);

//            PrintArray(newArr);
//            Console.ReadKey();
//        }
//        public static int[] ReverseArray(int [] arr)
//        {
//            int[] reverseArray = new int[arr.Length];

//            for (int i = 0; i < arr.Length; i++)
//                reverseArray[i] = arr[arr.Length - i - 1];

//            return reverseArray;
//        }
//        public static void PrintArray(int[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//                Console.WriteLine(arr[i]);
//        }
//    }
//}