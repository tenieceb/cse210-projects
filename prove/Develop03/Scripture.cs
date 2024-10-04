    public class Scripture
    {
        Reference _reference;
        public List<Word> _words = new List<Word>();

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";
            string[] textArray = text.Split(' ',',',';');
            foreach (string line in textArray)
            {
                _words.Add(new Word(line));
            }
        }

        public void HideRandomWord(int numberToHide)
        {
            Random random = new Random();
            numberToHide = random.Next(_words.Count);
            string toHide = numberToHide.ToString();

            Word hidden = new Word(toHide);
            hidden.Hide();
            

        }

        public string GetAllText()
        {
            
        }

        public bool IsCompletelyHidden()
        { }




    }
}
