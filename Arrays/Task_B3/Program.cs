using System;

//Խնդիր 3։ Ներմուծել երկչափ զանգված։ ներմուծված զանգվածից ստանալ նոր միաչափ զանգած,
//որի տարրերը ստացվում են երկչափ զանգածի այն տարրերից որոնք K ներմուծված թվին բազմապատիկ են։
//Խնդիրը լուծել նաև աստիճանաձև զանգավծի համար։


namespace Task_B3
{
    class Program
    {
        public static int[] MultiplayNthNum(int[,] array, int num)
        {
            int[] multArr = new int[array.Length];
            int k = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % num == 0)
                    {
                        multArr[k] = array[i, j];
                        k++;
                    }
                }
            }
            int[] newArr = new int[k];
            for (int i = 0; i < k; i++)
            {
                newArr[i] = multArr[i];
            }
            return newArr;
        }
        public static int[] MultiplayNthNumJagged(int[][] jaggedArr, int num) {
            int[] multArr = new int[jaggedArr.Length];
            int m = 0;

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    if (jaggedArr[i][j] % num == 0)
                    {
                        multArr[m++] = jaggedArr[i][j];
                    }
                }
            }
            int[] newArr = new int[m];
            for (int i = 0; i < m; i++)
            {
                newArr[i] = multArr[i];
            }
            return newArr;
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
        static void Main(string[] args)
        {
            int[,] array = {    {4,15,67,25,77},
                                {8,95,100,66,87},
                                {66,55,44,33,22}
                            };
            int[] arr = MultiplayNthNum(array, 5);
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
            int[][] jaggedArr = new int[5][];

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                jaggedArr[i] = new int[i + 3];
            }
            Console.WriteLine(new string('-', 50));
            FillJaged(jaggedArr);
            PrintJagged(jaggedArr);
            Console.WriteLine(new string('-', 50));

            int[] newArray = MultiplayNthNumJagged(jaggedArr,5);

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }

        }
    }
}
