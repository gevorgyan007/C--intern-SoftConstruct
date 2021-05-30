using System;

namespace Task4
{
    // Ներմուծել երկչափ զանգված։ ներմուծված զանգվածից գտնել ներմուծված N-րդ տողի մեծագույն արժեքը և տպել։
    class Program
    {
        public static int MaxValueArrayRow(int[,] array, int N)
        {
            int max = Int32.MinValue;
            for (int i = N; i <= N; i++)
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
        public static int MaxValueJaggedArrRow(int[][] jaggedArr,int N)
        {
            int max = Int32.MinValue;
            for (int i = N; i <= N; i++)
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
        static void Main(string[] args)
        {

            int[,] array = new int[3, 4]
            {
                {4,5,75,18 },
                {3,9,21,28 },
                {65,72,99,66},
            };


            Console.WriteLine($"Maximum value {1} -th row array is :: {MaxValueArrayRow(array, 1)}");

            int[][] jaggedArr = new int[5][];

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                jaggedArr[i] = new int[i + 3];
            }
            FillJaged(jaggedArr);
            PrintJagged(jaggedArr);

            Console.WriteLine($"Maximum value {4} -th row JaggedArray is :: {MaxValueJaggedArrRow(jaggedArr, 4)}");
        }
    }
}
