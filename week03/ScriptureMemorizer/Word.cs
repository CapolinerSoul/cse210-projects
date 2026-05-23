public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text=text;
        _isHidden = false;    
    }

    public void Hide()
    {
         _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (isHidden() == true){

            if(_text.Contains(','))
            {
                string result = new string('_', (_text.Length-1));
                return result + ',';
            }

            if(_text.Contains('.'))
            {
                string result = new string('_', (_text.Length-1));
                return result + '.';
            }

            else
            {
                string result = new string('_', _text.Length);
                return result;
            }
            }

        return _text;
    }
}