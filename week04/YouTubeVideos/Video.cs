public class Video
{
    public string _title;
    public string _author;
    public int _lenght;

    public int Count = 0;

    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int Length)
    {
        _title = title;
        _author = author;
        _lenght = Length;
    }

    public int GetNumberComments()
    {
        int Count = _comments.Count();
        return Count;
    }


}