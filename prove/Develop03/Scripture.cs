public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
        _random = new Random();
    }

    public void HideRandomWords(int numberToHide)
    {
    
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count <= numberToHide)
        {
            foreach (Word word in visibleWords)
                word.Hide();
        }
        else
        {
           List <int> indices = Enumerable.Range(0, visibleWords.Count).ToList();
            for (int i = 0; i < numberToHide; i++)
            {
                int indexToRemove = _random.Next(indices.Count);
                _words[indices[indexToRemove]].Hide();
                indices.RemoveAt(indexToRemove);
            }
        } 
        
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}\n\n";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

   public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    /*public bool IsCompletelyHidden()
    {
        return false;
    } */
    
}
