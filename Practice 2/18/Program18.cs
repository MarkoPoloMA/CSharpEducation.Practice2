//using System;

//namespace Practice_2
//{
//    class Program18
//    {
//        static public void Main()
//        {
//            string output = " ";
//            int[] arr = { 1, 1, 3, 4, -1, -4 };
//            DeleteMinusValue(ref arr, ref output);
//            PrintArray(arr);

//            Console.ReadKey();

//        }
//        static public void DeleteMinusValue(ref int [] arr, ref string output) 
//        {
//            for(int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] < 0)
//                {
//                    output += arr[i].ToString();
//                    arr = RemoveArray(arr, i);
//                    i--;
//                }    
//            }
//        }
//        public static int[] RemoveArray(int [] arr, int index)
//        {
//            int[] newArr = new int[arr.Length - 1];

//            for (int i = 0; i < index; i++)
//                newArr[i] = arr[i];
//            for (int i = index + 1; i < arr.Length; i++)
//                newArr[i-1] = arr[i];

//            return newArr;
//        }
//        public static void PrintArray(int[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//                Console.WriteLine(arr[i]);
//        }
//    }
//}
