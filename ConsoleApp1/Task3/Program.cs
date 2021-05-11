using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter simvol!");
            char ch =Convert.ToChar(Console.ReadLine());

            // check if ch is a letter
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                Console.WriteLine("You write small letters " + ch);
            else
                if (ch >= 'A' && ch <= 'Z')
                    Console.WriteLine("You writ capital letters " + ch);
            else
               // check if ch is a digit
               if (ch >= '0' && ch <= '9')
                Console.WriteLine("You writ digit " + ch);
            else
            // check if ch is a whitespace
            if ((ch == ' ') || (ch == '\n') || (ch == '\t'))
                Console.WriteLine("whitespace");
            else
                Console.WriteLine("You write other simvol");
        }
    }
}
