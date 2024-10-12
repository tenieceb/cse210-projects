using System.Collections.Generic;

public class Scripture
{
    Reference _reference;
    public List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        string[] textArray = text.Split(' ');
        foreach (string line in textArray)
        {
            _words.Add(new Word(line));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int i = 0;
        while (i < numberToHide) 
        {
            Random random = new Random();
            int index = random.Next(_words.Count);
            Word hidden = _words[index];

            if (hidden.IsHidden() is false)
            {
                hidden.Hide();
                i += 1;
            }
            
        } 

    }

    public string GetDisplayText()
    {
        List<string> wordTexts = new List<string>();
        foreach (Word word in _words)
        {
            wordTexts.Add(word.GetDisplayText());
        }
        

        return _reference.GetReferenceText()+ " " + string.Join(" ", wordTexts);

    }

    public bool IsCompletelyHidden()
    {

        foreach (Word word in _words)
        {
            if (word.IsHidden() is false)
            {
                return false;
            }
        }
        return true;
    }

}
