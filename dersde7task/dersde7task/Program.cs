using System;
using System.Collections.Generic;
using System.Linq;

namespace dersde7task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var input = new List<int>() {2,4,5,7,2,2,2 };
            var res=migratoryBirds(input);
            Console.WriteLine(res);
  
        }
        public static int migratoryBirds(List<int> arr)
        {
            var list = new List<int>();
            int count = 0;
            for (int i = 0; i < arr.Capacity; i++)
            {
                count = 0;
                for (int j = i + 1; j < arr.Capacity; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                list.Add(count);
            }
            return count;
            int max = list.Max();
            list.IndexOf(max);
            return arr[max];
        }


    }
}
