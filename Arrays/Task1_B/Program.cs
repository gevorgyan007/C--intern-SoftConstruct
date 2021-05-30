using System;

namespace Task_B2
{
    //Խնդիր 2։ Ներմուծել միաչափ զանգված։
    //ներմուծված զանգվածից հեռացնել 4 անգամից ավել կրկնվող տարրերը և տպել էկրանին։
    class Program
    {

        public static int[] deleteNth(int[] elements, int maxOcurrences)
        {
            Array.Sort(elements);



            return elements;
        }

        static void Main()
        {
            int[] array = { 1, 5, 4, 2, 6, 2, 7, 2, 8, 2, 2,11 };
            foreach (var item in deleteNth(array,3))
            {
                Console.Write(item + " ");
            }
        }
    }
 }

