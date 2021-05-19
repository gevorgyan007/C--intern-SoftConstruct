using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[3];
            for (int i = 0; i < 3; i++)
            {
                char ch = Convert.ToChar(Console.ReadLine());
                arr[i] = ch;
            }
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j <arr.Length-1-i;  j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        char temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] +" ");
            }


        }
    }
}
