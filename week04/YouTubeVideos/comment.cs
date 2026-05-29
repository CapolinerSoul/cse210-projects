public class Comment
{
    public string _commenter;
    public string _text;

    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _text = comment;
    }

    public string commentShow()
    {
        return $"{_commenter}\n{_text}";
    }
}