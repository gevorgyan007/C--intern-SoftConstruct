using System;

namespace Task2
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

            Console.WriteLine(new string('-',10));

            //check smallest number
            if (num1 < num2 && num1 < num3)
                Console.WriteLine(num1);
            if (num2 < num1 && num2 < num3)
                Console.WriteLine(num2);
            if (num3 < num1 && num3 < num2)
                Console.WriteLine(num3);

            //check medium number
            if (num2 < num1 && num1 < num3)
                Console.WriteLine(num1);
            else if (num3 < num1 && num1 < num2)
                Console.WriteLine(num1);
            if (num1 < num2 && num2 < num3)
                Console.WriteLine(num2);
            else if (num3 < num2 && num2 < num1)
                Console.WriteLine(num2);
            if (num1 < num3 && num3 < num2)
                Console.WriteLine(num3);
            else if (num2 < num3 && num3 < num1)
                Console.WriteLine(num3);

            //check largest number
            if (num2 < num1 && num3 < num1)
                Console.WriteLine(num1);
            if (num1 < num2 && num3 < num2)
                Console.WriteLine(num2);
            if (num1 < num3 && num2 < num3)
                Console.WriteLine(num3);
        }
    }
}
