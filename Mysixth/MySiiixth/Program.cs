using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mysixth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a lifetime guessing game !");
            Random random = new Random();
            int NumberToGuess = random.Next(1, 50);
            bool Guess = false;

            while(!Guess)
            {
                Console.Write("Guess a number between 1 and 50: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == NumberToGuess)
                {
                    Guess = true;
                    Console.WriteLine("That's a correct guess");
                }
                else if(num > NumberToGuess)
                {
                    Console.WriteLine("That was too much");
                }
                else
                {
                    Console.WriteLine("That was too low");
                }
               
                
                 
            }
            Console.WriteLine("GOODBYEEE!");
            Console.ReadLine();
            

        }
    }
}
