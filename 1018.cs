using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayLength = Console.ReadLine().Split(" ");
            char[,,] arr = {
            {
            {'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
            {'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
            {'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
            {'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
            {'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
            {'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
            {'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
            {'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' }
            },
            {
            {'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
            {'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
            {'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
            {'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
            {'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
            {'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
            {'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
            {'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
            }
            };
            string[] input = new string[int.Parse(arrayLength[0])];
            int result = 999999;
            int trash = 0;

            if (int.Parse(arrayLength[0]) < 8 && int.Parse(arrayLength[1]) < 8)
                return;
            for (int i = 0; i < int.Parse(arrayLength[0]); i++)
                input[i] = Console.ReadLine();



            for (int x = 0; x < 2; x++)
            {
                int q = 0;
                do
                {
                    int w = 0;
                    do 
                    {
                        trash = 0;
                        for (int i = 0; i < 8; i++)
                            for (int j = 0; j < 8; j++)
                            {
                                if (arr[x, i, j] != input[i + q][j + w])
                                    trash++;
                            }   
                        if (trash < result)

                            result = trash;

                        w++;
                    } while (w < int.Parse(arrayLength[1]) + 1 - 8);
                    q++;
                } while (q < int.Parse(arrayLength[0]) + 1 - 8);
            }



            Console.WriteLine(result);
        }
    }
}
