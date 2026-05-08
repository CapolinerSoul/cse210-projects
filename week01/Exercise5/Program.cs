using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string username = ProptUserName();
        int favoritenum = PromptUserNumber();
        double square = SquareNumber(favoritenum);
        DisplayResult(username, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string ProptUserName()
    {
        Console.Write("Enter Your name: ");
        string response = Console.ReadLine();
        return response;
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter Your favorite number: ");
        string response = Console.ReadLine();
        int responseinted = int.Parse(response);
        return responseinted;
    }
    static double SquareNumber(int num)
    {
        double number = Math.Sqrt(num);
        return number;
    }
    static void DisplayResult(string name, double sqnum)
    {
        Console.WriteLine($"{name}, the square number of your number is {sqnum}");
    }
}