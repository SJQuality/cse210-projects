
public class Scripture
{
    Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        //Scriputre text into list of words
        string[] splitWords = text.Split(" ");

        /// Create a Word object for each string and add it to the list
        foreach (string splitWord in splitWords)
        {
            Word word = new Word(splitWord);

            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);

            if (IsCompletelyHidden() == true)
            {
                break;
            }

            else if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();

            }

            else
            {
                // Retry this iteration since no new word was hidden.
                i--;
            }
        }
    }

    public string GetDisplayText()
    {
        string scripture = "";

        foreach (Word word in _words)
        {
            scripture = scripture + word.GetDisplayText() + " ";
        }
        return scripture;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

    public static Scripture LoadFromFile()
    {
        string file = "passages.txt";
        string[] lines = System.IO.File.ReadAllLines(file);

        int lineCount = lines.Count();

        int verseToGet = GetRandomVerse(lineCount);

        for (int i = 0; i < lines.Length; i++)
        {
            if (i == verseToGet)
            {
                string line = lines[i];
                string[] parts = line.Split("|");

                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int startVerse = int.Parse(parts[2]);
                int endVerse = int.Parse(parts[3]);
                string text = parts[4];

                Reference reference = new Reference(book, chapter, startVerse, endVerse);
                Scripture scripture = new Scripture(reference, text);
                return scripture;
            }

        }
        return null;

    }

    private static int GetRandomVerse(int lineCount)
    {
        Random random = new Random();
        int index = random.Next(lineCount);

        return index;
    }

    public string GetReferenceText()
    {
        return _reference.GetDisplayText();
    }

}