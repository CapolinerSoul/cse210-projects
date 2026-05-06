using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Whats the grade percentage: ");
        string usergrade = Console.ReadLine();
        int grade = int.Parse(usergrade);
        int lastdigit = grade %10;
        string additional = "";

        if (lastdigit >= 7)
        {
            additional = "+";
        }
        else if (lastdigit <= 3)
        {
            additional = "-";
        }

        if (grade >= 90)
        {
            if (lastdigit >= 7)
            {
                Console.WriteLine($"The grade is A");
            }
            else
            {
                Console.WriteLine($"The grade is A{additional}");
            }
        }
        else if (grade >= 80)
        {
            Console.WriteLine($"The grade is B{additional}");
        }
        else if(grade >= 70)
        {
            Console.WriteLine($"The grade is C{additional}");
        }
        else if (grade >=60)
        {
            Console.WriteLine($"The grade is D{additional}");
        }
        else
        {
            Console.WriteLine($"The grade is F");
        }
    }
}