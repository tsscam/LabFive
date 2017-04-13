using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Lab5_DiceRolling
{
    class Program
    {
        static void Main(string[] args)
        {
            int diceOne;
            int diceTwo;
            string Answer;
            int rollNumber = 1;


            bool run = true;


            do
            {
                Console.WriteLine("Welcome to the Grand Circus Casino!!  Roll the dice? (y/n): ");

                Answer = Console.ReadLine().ToLower();
                if (Answer == "y")
                {
                    //Label for the roll
                    Console.WriteLine("Roll {0}: ", rollNumber);

                    //Here is where the app will ask the user for the number of sides on the dice.
                    Console.WriteLine("How many sides are on the dice you are about to roll");
                    int numberOfSides = Int16.Parse(Console.ReadLine());
                    Random randomObject = new Random();

                    Console.WriteLine("The First Random Number is: {0} ", randomObject.Next(numberOfSides) + 1);
                    

                    Console.WriteLine("The Second Random is: {0}", randomObject.Next(numberOfSides) + 1);
                   

                   
                }
                else if (Answer == "n")
                {
                    Console.WriteLine("Thanks for playing, have a great day!");
                    run = false;

                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }


            } while (run);
        }
    }
}
