public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void run()
    {
        DisplayStartingMessage();
        
        while (true)
        {   
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result)) 
            {
                _duration = result;
                break;
            }
            Console.WriteLine("type a valid number: ");
        }

        DateTime starttime = DateTime.Now;
        DateTime endTime = starttime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in ");
            ShowCountDown(5);
            Console.WriteLine("Breath out ");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
        ShowSpinner(5);
    }
}