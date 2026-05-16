using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal theJournal = new Journal();
        bool jijo = true;

        while (jijo==true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file ");
            Console.WriteLine("5. Exit Program");
            Console.Write("Enter Number: ");
            string response = "";
            response = Console.ReadLine();

            if (response == "1")
            {
                PromptGenerator promptGen = new PromptGenerator();
                Console.WriteLine(promptGen.GetRandomPromp());
                Entry anEntry = new Entry();
                anEntry._promptsText =promptGen.GetRandomPromp();
                string today = DateTime.Now.ToString("d");
                anEntry._date = today;
                 Console.Write(":");
                 string today_entry = "";
                 today_entry = Console.ReadLine();
                anEntry._entryText= today_entry;
                
                theJournal.AddEntry(anEntry);
            }

            else if (response == "2")
            {
                theJournal.DisplayAll();
            }
            else if (response == "3")
            {
                string savefilepath = "";
                Console.Write("Enter the Name of the file: ");
                savefilepath = Console.ReadLine();
                theJournal.SaveToFile(savefilepath);
            }
            else if (response == "4")
            {
                string loadfilepath = "";
                Console.Write("Enter the Name of the file to load: ");
                loadfilepath = Console.ReadLine();
                theJournal.LoadFromFile(loadfilepath);
            }
            else if (response == "5")
            {
                Console.WriteLine("Goodbye");
                jijo = false;
            }
        }
            
        

            

        
    }
}