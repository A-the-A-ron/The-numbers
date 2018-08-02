using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string leave = "";
            do
            {
                string guess = "";
                Console.WriteLine("I'm thinking of a number between 1-500. You have ten guesses. you can say 'I GIVE UP!' at any time to quit.");
                Random rnd = new Random();
                int number = rnd.Next(1, 501);

                do
                {
                    guess = Console.ReadLine();
                    if (guess == "I GIVE UP!")
                    {
                        Console.WriteLine("Very well");
                        break;
                    }
                    else if (guess != "I GIVE UP!" ){
                        int i = Convert.ToInt32(guess);
                        if (i > number)
                        {
                            Console.WriteLine("smaller");
                        }
                        else if (i < number)
                        {
                            Console.WriteLine("BIGGER");
                        }
                        else if (i == number)
                        {
                            Console.WriteLine("Correct!!");
                            guess = "correct";
                            break;
                        }
                    

                } while (guess != "correct" || guess != "I GIVE UP!");

                Console.WriteLine("Would you like to play again? (y/n)");
                leave = Console.ReadLine();
                if (leave == "n")
                {
                    break;
                }
            } while (leave != "n");
            Console.WriteLine("Goodbye");
        }
    }
}
