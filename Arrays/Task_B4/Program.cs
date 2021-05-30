using System;

//Խնդիր 4։ Ներմուծել երկչափ զանգված։ ներմուծված զանգվածից ստանալ նոր միաչափ զանգած,
//որի տարրերը ստացվում են երկչափ զանգածի ամեն տողի մեծագույն արժեքներից։
//Խնդիրը լուծել նաև աստիճանաձև զանգավծի համար։

namespace Task_B4
{
    
    class Program
    {
        public static int[] MaxElementOfArray(int[,] array)
        {
            int[] multArr = new int[array.Length];
            int k = 0;
            
            int max = Int32.MinValue;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                max = Int32.MinValue; 
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                        max = array[i, j];
                }
                multArr[k++] = max;
            }
            int[] newArr = new int[k];
            for (int i = 0; i < k; i++)
            {
                newArr[i] = multArr[i];
            }
            return newArr;
        }
        static void Main()
        {
            int[,] array = {    {4,15,67,25,77},
                                {8,95,100,66,87},
                                {66,55,44,33,22},
                                {4,15,88,25,77}
                            };
            int[] arr = MaxElementOfArray(array);
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
