class Comment
{
  
    private string _nameOfCommenter; 
    private string _text; 

   public Comment(string NameOfCommenter, string Text)
    {
         _nameOfCommenter = NameOfCommenter ; 
         _text = Text;
    } 

   
 public string NameOfCommenter
    {
        get { return _nameOfCommenter; }
    }

    public string Text
    {
        get { return _text; }
    }

}
