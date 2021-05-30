using System;

//Խնդիր 2։ Ներմուծել երկչափ զանգված։ ներմուծված զանգվածից ստանալ նոր միաչափ զանգած,
//որի տարրերը ստացվում են երկչափ զանգածի զույգ տարրերից։ 
//Խնդիրը լուծել նաև աստիճանաձև զանգավածի համար։

namespace Task2
{
    class Program
    {
        public static int[] EvenArray(int[,] array)
        {
            int[] arr;
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
            arr = new int[count];
            int n = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        arr[n] = array[i, j];
                        n++;
                    }
                }
            }
            return arr;
        }
        public static int[] EventArrayJagged(int[][] jaggedArr)
        {
            int[] array;
            int count = 0;
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    if (jaggedArr[i][j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

            array = new int[count];
            int m = 0;
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    if (jaggedArr[i][j] % 2 == 0)
                    {
                        array[m] = jaggedArr[i][j];
                        m++;
                    }
                }
            }
            return array;
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
        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
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


            Console.WriteLine(new string('-', 50));
            PrintArray(array);
            Console.WriteLine(new string('-', 50));

            int[] arr = EvenArray(array);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int[][] jaggedArr = new int[5][];

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                jaggedArr[i] = new int[i + 3];
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
            FillJaged(jaggedArr);
            PrintJagged(jaggedArr);
            Console.WriteLine(new string('-', 50));

            int[] newArray = EventArrayJagged(jaggedArr);

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
        }
    }
}

