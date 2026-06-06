using System.Reflection.Metadata.Ecma335;

public class Activity
{
    public string _name; 
    public string _description;
    public int _duration = 10;

    public Activity()
    {

    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n{_description}\nHow long, in seconds would you like for your session: ");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }
    
    public void ShowSpinner(int seconds)
    {
        DateTime starttime = DateTime.Now;
        DateTime endTime = starttime.AddSeconds(seconds);
        List<string> animation = ["|","/","—","\\"];
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animation[i];

            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i ++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }
            
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        Console.WriteLine("Done.");
    }
}