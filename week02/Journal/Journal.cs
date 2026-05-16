using System.Text;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("Displaying All");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
       var sb = new StringBuilder();

       foreach(Entry entry in _entries)
        {
            sb.AppendLine($"{entry._date}࿉{entry._promptsText}࿉{entry._entryText}");
        }

        File.WriteAllText(file, sb.ToString());
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        using (var reader = new StreamReader(file))
        {
            string line;
            while ((line =reader.ReadLine()) !=null)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                string[] values = line.Split('࿉');

                var entrytotal = new Entry
                {
                    _date = values[0],
                    _promptsText = values[1],
                    _entryText = values[2]
                };
                
                _entries.Add(entrytotal);
            }
}
    }
    
}
