class Entry
{
    public string _date = "";
    public string _promptsText = "";

    public string _entryText = "";

    public Entry()
    {
        
    }

   public void Display()
   {
    Console.WriteLine($"{_date}");
    Console.WriteLine("");
    Console.WriteLine($"{_promptsText}");
    Console.WriteLine("");
    Console.WriteLine($"{_entryText}");
    Console.WriteLine("");
   } 
}