using System;

class Program
{
    static void Main(string[] args)
    {
        bool numbering = true;
        List<int> numbers = new List<int>();
        Console.WriteLine("  Enter a list of numbers, type 0 when finished.");
        while (numbering == true)
        {
            Console.Write("Enter Number: ");
            string response = "";
            response = Console.ReadLine();
            if (response=="0"){
                float averagenum = 0;
                int maxnum = 0;
                int summednum = numbers.Sum();;
                foreach (int i in numbers)
                {
                    if (i > maxnum)
                    {
                        maxnum = i;
                    }
                }
                averagenum = (float)summednum/numbers.Count;
                numbering = false;
                Console.WriteLine($"The Sum is: {summednum}");
                Console.WriteLine($"The average is: {averagenum}");
                Console.WriteLine($"The largest number is: {maxnum}");
            }
            else
            {
            int responseadded = int.Parse(response);
            numbers.Add(responseadded);
            }
        }
    }
}