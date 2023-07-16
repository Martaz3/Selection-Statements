using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            //var r = new Random();
            //var favNumber = r.Next(0, 1001);


            //Console.WriteLine("Pick a number from 1 - 1000");
            //var userInput = int.Parse(Console.ReadLine());

            //if (userInput < favNumber)
            //{
            // Console.WriteLine($"{userInput} is too low.");
            //}
            //else if (userInput > favNumber) 
            //{
            //Console.WriteLine($"{userInput} is too high.");
            //}
            //else
            //{
            //Console.WriteLine("You guessed it.");
            //}
            //Switch Case

            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch(subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I hate math!");
                    break;
                case "science":
                    Console.WriteLine("I'm a scientist.");
                    break;
                case "english":
                    Console.WriteLine("I am an author.");
                    break;
                case "pe":
                    Console.WriteLine("I love to be active!");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break;


            }
        }
    }
}