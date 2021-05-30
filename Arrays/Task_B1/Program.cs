using System;

//Խնդիր 1։ Ներմուծել միաչափ զանգված։ ներմուծված զանգվածից հեռացնել կրկնվող տարրերը և տպել էկրանին։

namespace Task_B1
{
    class Program
    {
        public static int[] RemoveDublicate(params int[] array)
        {
            int numDups = 0, prevIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool foundDup = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        foundDup = true;
                        numDups++;
                        break;
                    }
                }

                if (foundDup == false)
                {
                    array[prevIndex] = array[i];
                    prevIndex++;
                }
            }
            int[] newArr = new int[array.Length-numDups];
            for (int k = 0; k < newArr.Length; k++)
            {
                newArr[k] = array[k];
            }
            return newArr;
        }
        static void Main(string[] args)
        { int[] arr = { 5, 7, 5, 6, 5, 18, 6, 7 };
            int[] array = RemoveDublicate(arr);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
