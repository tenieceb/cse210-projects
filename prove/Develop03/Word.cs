public class Word
{
    string _text;
    bool _isHidden = false;

    public Word(string text)
    { 
        _text = text; 
    }

    public void Hide()
    {
        foreach (char letter in _text)
        {
            _text = _text.Replace(letter , '_');
            
        }
        
        _isHidden = true;
    }

    public void Show() 
    {
        
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }


}