using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(" ");
            int max = 0;
            float result = 0;

            for(int i = 0; i < num; i++)
                if (max < int.Parse(arr[i]))
                    max = int.Parse(arr[i]);
            
            for(int i = 0; i < num; i++)
                result += (float.Parse(arr[i]) / max) * 100;

            Console.WriteLine(result / num);
        }
    }
}
