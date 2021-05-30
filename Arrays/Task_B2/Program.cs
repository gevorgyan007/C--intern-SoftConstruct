using System;
using System.Collections.Generic;

namespace Task_B2
{
    //Խնդիր 2։ Ներմուծել միաչափ զանգված։ ներմուծված զանգվածից հեռացնել 4 անգամից ավել կրկնվող տարրերը և տպել էկրանին։
    class Program
    {
        static void RemoveElements(int[] arr,int n, int k)
        {
            Dictionary<int,int> mp = new Dictionary<int,int>();

            for (int i = 0; i < n; ++i)
            {

                if (mp.ContainsKey(arr[i]))
                    mp[arr[i]]++;
                else
                    mp[arr[i]] = 1;
            }

            for (int i = 0; i < n; ++i)
            {
               
                if (mp.ContainsKey(arr[i]) && mp[arr[i]] <= k)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 3, 2, 89, 4, 2, 7, 2, 89 };
                RemoveElements(arr,10, 3);
            
        }
    }
}
