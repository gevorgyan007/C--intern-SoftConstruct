using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1 number!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2 number!");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 3 number!");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('-', 22));

            //find largest number
            if (num1 > num2 && num1 > num3)
                Console.WriteLine($"Largest number is {num1}");
            else if (num2 > num1 && num2 > num3)
                Console.WriteLine($"Largest number is {num2}");
            else 
                Console.WriteLine($"Largest number is {num3}");
        }
    }
}
