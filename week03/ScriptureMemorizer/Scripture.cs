using System.Data;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitText = text.Split(' ');

        foreach (string words in splitText)
        {
            _words.Add(new Word(words));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();

        var availableIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].isHidden())
            {
                availableIndexes.Add(i);
            }
        }

        availableIndexes = availableIndexes
            .OrderBy(x => random.Next())
            .ToList();

        for (int i = 0; i < numberToHide && i < availableIndexes.Count; i++)
        {
            _words[availableIndexes[i]].Hide();
        }
    }
    public string GetDisplayText()
    {
        string refsul = (_reference.GetDisplayText());
      
        string result = string.Join(" ", _words.Select(w => w.GetDisplayText()));

        return refsul + ' ' + result;
    }

    public bool isCompletelyHidden(){
        return _words.All(w=> w.isHidden());
    }
}