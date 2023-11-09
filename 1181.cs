using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            //string[] input = new string[num];
            List<string> input = new List<string>();

            for (int i = 0; i < num; i++)
            {
                input.Add(Console.ReadLine().ToLower());
            }

            input = input.Distinct().ToList();
            input.Sort();
            input = input.OrderBy(x => x.Length).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                    Console.WriteLine(input[i]);
            }
        }
    }
}