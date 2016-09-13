using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoskesWeek2Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            do {
                Console.WriteLine("L3t's play a gam3, 3nt3r an int3g3r and s33 if you win.");
                number = int.Parse(Console.ReadLine());
                if (number%3==0)
                {
                    Console.WriteLine("You Won!");
                    break;
                }
                else
                {
                    Console.WriteLine("You Lose");
                }
            }
            while (true);
        }
    }
}
