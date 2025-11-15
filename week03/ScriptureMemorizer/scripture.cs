public class Scripture
{
    private Reference _reference;
    private List<Words> _words = new List<Words>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = new List<Words>();

        string[] parts = text.Split(""); // divide por palabras

        foreach (string part in parts)
        {
            _words.Add(new Words(part));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            bool wordHidden = false;

            while (!wordHidden)
            {
                int index = random.Next(_words.Count);
                Words Chosen = _words[index];

                if (!Chosen.IsHidden())
                {
                    Chosen.Hide();
                    wordHidden = true;
                }
                if (_words.All(w => w.IsHidden()))
                {
                    return;
                }
            }
        }

    }
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();

        List<string> processedWords = new List<string>();

        foreach (Words word in _words)
        {
            processedWords.Add(word.GetDisplayText());
        }
        string scriptureText = string.Join(" ", processedWords);

        return referenceText + "\n" + scriptureText;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Words word in _words)
        {
            if (!word.IsHidden())
            {
                return false; 
            }
        }

        return true; 
    }

}