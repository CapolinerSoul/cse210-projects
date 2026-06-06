using System;

class Program
{
    public static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {   //Keeping the console clean for better reading
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();


            //Decided on Switch case instead of if else for a less messy code.
            switch (input)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.run();
                    break;

                case "2":
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.run();
                    break;

                case "3":
                    Console.Clear();
                    ListingActivity listing = new ListingActivity();
                    listing.run();
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    keepRunning = false;
                    break;

                default:
                    Console.WriteLine("\nInvalid option. Press Enter to try again...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}