using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main()
        {
            var r = new Random();
            var favNumber = r.Next(1, 20);


            Console.WriteLine("Try to guess my favorite number.");
            int userInput = int.Parse(Console.ReadLine());


            if (userInput > favNumber)
            {
                Console.WriteLine($"Too high. {userInput} is toooooo high.");
            }

            else if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low.");
            }

            else
            {
                Console.WriteLine($"{favNumber} IS my favorite number! Are you pschyic?!?");
            }

            //-----------------Exercise 2----------------------------


            Console.WriteLine($"What is your favorite school subject?");
            
            var favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("I like Math too!");
                    break;
                case "english":
                    Console.WriteLine("I like English too!");
                    break;
                case "science":
                    Console.WriteLine("I like Science too!");
                    break;
                case "art":
                    Console.WriteLine("I like Art too!");
                    break;
                default: 
                    Console.WriteLine("It's ok if you do not have a favorite subject.");
                    break;
            }

        }
    }
}
