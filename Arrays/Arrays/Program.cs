using System;

//Խնդիր 1։ Ներմուծել երկչափ զանգված։ հաշվել ներմուծված զանգվածի 5-ին բազմապատիկ տարրի քանակը։ 
//Խնդիրը լուծել նաև աստիճանաձև զանգավծի համար։


namespace Arrays
{
    class Program
    {
        public static int MultipleOfFiveJagged(int[][] jaggedArr)
        {
            int count = 0;

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    if (jaggedArr[i][j] % 5 ==0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static int MultipleOfFive(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 5 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static void PrintJagged(int[][] jaggedArr) {
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write($"{jaggedArr[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static void PrintArray(int[,] array) {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public static void FillArr(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 100);
                }
            }
        }
        public static void FillJaged(int[][] jaggedArr) {
            
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    jaggedArr[i][j] = new Random().Next(2, 100);
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Input rows");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input colums");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[row, col];
            FillArr(array);

            PrintArray(array);
            Console.WriteLine(new string('-', 50));

            int countFive = MultipleOfFive(array);
            Console.WriteLine($"The number of multiple elements in the 5th is {countFive}");

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Input rows");
            int rowjagg = Convert.ToInt32(Console.ReadLine());

            int[][] jaggedArr = new int[rowjagg][];

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                jaggedArr[i] = new int[i + 3];
            }

            FillJaged(jaggedArr);

            PrintJagged(jaggedArr);

            int countFiveJagged = MultipleOfFiveJagged(jaggedArr);
            Console.WriteLine($"The number of multiple elements in the 5th is {countFiveJagged}");
            Console.WriteLine(new string('-', 50));
        }
    }
}
