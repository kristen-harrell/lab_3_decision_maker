using System;
using System.Net.Security;
using System.Runtime.CompilerServices;

namespace Lab_3_decision_maker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool playAgain = true;
            string userName;

                Console.WriteLine("Welcome to Decision Maker!");
                
                Console.WriteLine("Please enter your name:");
                userName = Console.ReadLine();

                Console.WriteLine($"Nice to meet you {userName}");

                while (playAgain)
                {
                    Console.WriteLine("Please enter a whole number between 1 and 100");

                        while (!int.TryParse(Console.ReadLine(), out number))

                        Console.Write("Your entry is not a number. Please try again: ");
                {

                    if (number % 2 != 0)
                    {
                        Console.WriteLine($"Your number {number} is Odd");
                    }

                    else if (number % 2 == 0 && number >= 2 && number <= 25)
                    {
                        Console.WriteLine($"Your number {number} is Even and less than 25");
                    }

                    else if (number % 2 == 0 && number >= 26 && number <= 60)
                    {
                        Console.WriteLine($"Your number {number} is Even");
                    }

                    else if (number % 2 == 0 && number > 60)
                    {
                        Console.WriteLine($"Your number {number} is Even");
                    }

                    else if (number % 2 != 0 && number > 60)
                    {
                        Console.WriteLine($"Your number {number} is Odd");
                    }

                }
             Console.WriteLine($"Would you like to play again {userName}? Enter y/n");
             string decision = Console.ReadLine();
                
                if (decision == "y")
                {
                    playAgain = true;
                }

                else
                {
                    Console.WriteLine("Thanks for playing!!");
                    break;
                }
            }
        }
    }
}
