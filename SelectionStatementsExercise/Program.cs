using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 50);

            Console.WriteLine("Try to guess my favorite number:");
            var userInput = int.Parse(Console.ReadLine());
            while (userInput != favNumber)
            {
                if(userInput > favNumber)
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("Too low");
                }
                Console.WriteLine("Try again:");
                userInput = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Correct! My favorite number is {favNumber}.");
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();
            switch (subject)
            {
                case "math":
                    Console.WriteLine("Nerd");
                    break;
                case "english":
                    Console.WriteLine("You might want to get that checked out");
                    break;
                case "science":
                    Console.WriteLine("I can get behind that");
                    break;
                case "history":
                    Console.WriteLine("Not my favorite.");
                    break;
                case "gym":
                    Console.WriteLine("We would be friends");
                    break;
                default:
                    Console.WriteLine("Nerd");
                    break;
            }


        }
    }
}
