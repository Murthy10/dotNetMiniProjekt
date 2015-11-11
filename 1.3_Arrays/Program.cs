using System;

namespace _1._3_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 3, 5, 7, 9 };
            PrintArray(arr1);
            Console.WriteLine(Sum(arr2));

            // TODO: PrintArray für alle Arrays ausführen

            // TODO: Sum für alle Arrays ausführen / Total auf ausgeben

            Console.ReadKey();
        }

        public static void PrintArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }
        

        public static int Sum(int[] array)
        {
            int sum = 0;
            foreach(int i in array)
            {
                sum += i;
            }
            return sum;
        } 

    }
}
