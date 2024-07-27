//using System;

//namespace Practice_2
//{
//    class Program19
//    {
//        static public void Main()
//        {
//            int size = 10;
//            int[] arr = new int[size];
//            arr = RandomArray(arr);
//            int difer = VarianceBetweenMaxAndMinValues(arr);
//            Console.WriteLine(difer);

//            Console.ReadKey();
//        }
//        public static int[] RandomArray(int[] arr)
//        {
//            Random random = new Random();
//            for (int i = 0; i < arr.Length; i++)
//                arr[i] = random.Next(1, 100);

//            return arr;
//        }
//        public static int VarianceBetweenMaxAndMinValues(int []arr)
//        {
//            int max = arr[0];
//            int min = arr[0];
//            foreach (int elem in arr)
//            {
//                if (elem > max) 
//                    max = elem;
//                if (elem < min) 
//                    min = elem;
//            }

//            return max - min;
//        }
//    }
//}
