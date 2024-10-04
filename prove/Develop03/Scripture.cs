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

        
      public void HideRandomWords(int numberToHide)
      {
          int i = 0;
          do
          {
              Random random = new Random();
              int index = random.Next(_words.Count);
              string toHide = index.ToString();

              Word hidden = new Word(toHide);
              hidden.Hide();
              i += 1;
          } while (i <= numberToHide);

        }

        public string GetAllText()
        {
            
        }

        public bool IsCompletelyHidden()
        { }




    }
