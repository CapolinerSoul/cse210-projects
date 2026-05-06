using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        bool guessing = true;
        String response;
        while (guessing == true)
        {
            Console.WriteLine($"Guess the magic Number {number}");
            Console.Write("Your guess: ");
            response = Console.ReadLine();
            int magicguess = int.Parse(response);
            if (magicguess > number)
            { Console.WriteLine("lower");}
            if (magicguess < number)
            {
                Console.WriteLine("Higher");
            }
            if (magicguess == number)
            {
                Console.WriteLine("You guessed it!");
                guessing = false;
            }
        }

    }
}