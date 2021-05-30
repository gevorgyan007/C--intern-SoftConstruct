using System;

//Ներմուծել երկչափ զանգված։ ներմուծված զանգվածից գտնել մեծագույն արժեքը և տպել:
// Խնդիրը լուծել նաև աստիճանաձև զանգավծի համար։

namespace Task3
{
    
    class Program
    {
        public static int MaxValueArray(int[,] array) {
            int max = Int32.MinValue;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                        max = array[i, j];
                }
                // Console.WriteLine();
            }
            return max;
        }
        public static int MaxValueJaggedArr(int[][] jaggedArr)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    if (jaggedArr[i][j] > max)
                    {
                        max = jaggedArr[i][j];
                    }
                }
            }
            return max;
        }
        public static void FillJaged(int[][] jaggedArr)
        {

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    jaggedArr[i][j] = new Random().Next(2, 100);
                }
            }
        }
        public static void PrintJagged(int[][] jaggedArr)
        {
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write($"{jaggedArr[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
        public   static void Main(string[] args)
        {

            int[,] array = new int[3, 4]
            {
                {4,5,75,18 },
                {3,9,21,28 },
                {65,72,99,66},
            };
            Console.WriteLine($"Maximum value array is :: {MaxValueArray(array)}");
            int[][] jaggedArr = new int[5][];

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                jaggedArr[i] = new int[i + 3];
            }

            FillJaged(jaggedArr);
            PrintJagged(jaggedArr);
            Console.WriteLine($"Maximum value array is :: {MaxValueJaggedArr(jaggedArr)}");
        }
    }
}
