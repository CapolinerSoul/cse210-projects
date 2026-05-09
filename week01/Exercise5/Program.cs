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
        int square = SquareNumber(favoritenum);
        DisplayResult(username, square);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string ProptUserName()
    {
        Console.Write("Please enter Your name: ");
        string response = Console.ReadLine();
        return response;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter Your favorite number: ");
        string response = Console.ReadLine();
        int responseinted = int.Parse(response);
        return responseinted;
    }
    static int SquareNumber(int num)
    {
        int number = num*num;
        return number;
    }
    static void DisplayResult(string name, int sqnum)
    {
        Console.WriteLine($"{name}, the square number of your number is {sqnum}");
    }
}