    using System;

    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words = new List<Word> ();

        public Scripture (Reference reference, string words)
        {
            _reference = reference;
            string[] array = words.Split(' ');
            foreach (string x in array)
            {
             Word word = new Word(x);
             _words.Add(word);
             Console.WriteLine(word);    
            }
        }

        public void Hiddewords()
        {
            int i = 0;
            while (i < 3 & IscompletelyHidden() == false)
            {
                Random rnd = new Random();
                int index = rnd.Next(_words.Count);
                if (_words[index].IsHidden() == false)
                {
                    _words[index].Hide();
                    i++;
                }
            } 
        }

        public void PrintText ()
        {
            Console.Write(_reference.GetText() + "");
            foreach (Word x in _words)
            {
                Console.Write($"{x.GetRendered()} ");
            }
        }

        public bool IscompletelyHidden ()
        {
            foreach (Word x in _words)
            {
                if (!x.IsHidden())
                {
                    return false;
                }
            }
            return true;
        }

    }