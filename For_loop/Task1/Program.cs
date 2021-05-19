using System;

namespace Task1
{
    class Program
    {
        public static int MaxValue() {
            int min = Int32.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < min)
                {
                    min = number;
                }
                
            }
            return min;
        }
        public static void Main()
        {
            Console.WriteLine(MaxValue());

        }

    }
}
