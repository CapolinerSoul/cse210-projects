public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chap, int verse)
    {
        _book = book;
        _chapter = chap;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chap, int verse, int endverse)
    {
        _book = book;
        _chapter = chap;
        _verse = verse;
        _endVerse = endverse;
    }

    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
          return ($"{_book} {_chapter}:{_verse}");  
        }
        else
        {
          return ($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }
        
    }
}