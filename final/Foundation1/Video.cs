class Video
{
    public string _title; 
    public string _author; 
    public int _length; // Length in seconds
    private List<Comment> _comments;

    public Video(string Title, string Author, int Length)
    {
      _title =  Title;
      _author = Author;
      _length = Length;
      _comments = new List<Comment>();
    }

    public void AddComment(string NameOfCommenter, string Text)
    {
        Comment comment = new Comment(NameOfCommenter, Text);
        _comments.Add(comment);
    }

    public int GetNumComments()
    {
        return _comments.Count;
    }

    public string Title
    {
        get { return _title; }
    }
    public string Author
    {
        get { return _author; }
    }

    public int Length
    {
        get { return _length; }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of comments: {GetNumComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"  -  {comment.NameOfCommenter} :  {comment.Text}");
        }
        Console.WriteLine();
    }
}
