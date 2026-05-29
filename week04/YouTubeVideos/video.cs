using System.Security.Cryptography;

public class Video
{

public string _title;
public string _author;
public int _videoLengh;
public List<Comment> _comments = new List<Comment>();

public Video(string title, string author, int lengh)
    {
        _author = author;
        _title = title;
        _videoLengh = lengh;
    }
public int numberComment()
    {
        return (_comments.Count);
    }
public void addComment(string commenter, string comment)
    {
        _comments.Add(new Comment(commenter, comment));
    }
public void displayAll()
    {
        Console.WriteLine($"{_author}\n{_title}\n{_videoLengh}\n");
        foreach(Comment co in _comments)
        {
            Console.WriteLine(co.commentShow());
        }
        Console.WriteLine(numberComment());
    }


}