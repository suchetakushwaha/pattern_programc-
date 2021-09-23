using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int row = 0; row<6; row++)
            {
                for(int col = 0; col<7; col++)
                {
                    if ((row == 0 && col % 3 != 0) || (row == 1 && col % 3 == 0) || (row - col == 2) || (row + col == 8))
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                   //Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
