public class Word
{
    string _text;
    bool _isHidden;

    public Word(string text)
    { 
        _text = text; 
    }

    public void Hide()
    {
        foreach (char letter in _text)
        {
            Console.Write("_");
        }
        
        _isHidden = true;
    }

    

    public void Show() 
    {
        _text = $"{_text}" ;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden)
        {
            return true;
        }
        else 
        { 
            return false;
        }
    }

    public string GetDisplayText()
    {
        return _text;
    }

}

