using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("[*]");

                    }
                    if (j == n)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
