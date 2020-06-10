using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIghLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int randnum = r.Next(1, 10);
            int correct = 0;

            Console.Write("Guess: ");
            int input = Convert.ToInt32(Console.ReadLine());


            while (correct == 0)
            {

                if (input < randnum)
                {
                    Console.WriteLine("No, the number is higher than that number.");
                    Console.Write("Guess Again: ");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                if (input > randnum)
                {
                    Console.WriteLine("No, the number is lower than that number.");
                    Console.Write("Guess Again: ");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                if (input == randnum)
                {
                    correct = 1;
                    Console.WriteLine("You guessed right!");
                }

            }

            Console.ReadKey();
        }
    }
}
