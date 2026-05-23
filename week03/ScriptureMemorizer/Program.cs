using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16, 19);


        string text = "For God so loved the world, that he gave his only begotten Son.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.isCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Program finished.");
                break;
            }

            Console.WriteLine("Press ENTER to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(1);
        }
    }
}