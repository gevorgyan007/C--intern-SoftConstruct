using System;

namespace Task5
{
    //Խնդիր 5։ Ներմուծել միաչափ զանգված։ Հաշվել զանգվածի մեծագույն արժեքը և տպել:
    class Program
    {
        public static int MaxValArr(int[] array)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public static void SortArray(int[] array) {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        static void Main()
        {
            Console.WriteLine("Input length array");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            Console.WriteLine($"Maximum value array is :: {MaxValArr(array)}");

            // Խնդիր 6։ Ներմուծել միաչափ զանգված։ Դասավորել ըստ աճման և տպել:
            SortArray(array);
            
            Console.WriteLine("Sort array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
