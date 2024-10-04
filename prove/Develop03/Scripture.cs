public class Scripture
{
    Reference _reference;
    public List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";
        char [] separator = {' ', ',' };
        string [] textArray = (text.Split(separator));
        _words.Add(textArray);
        


    }

    public Scripture() { }

    public void HideRandomWord(int numberToHide)
    {

    }

    public string GetAllText()
    {
        
    }

    public bool IsCompletelyHidden()
    { }