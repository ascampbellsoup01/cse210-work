public class Scripture
{
    public Reference Reference { get; set; }
    private List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        var random = new Random();
        for (int i = 0; i < count; i++)
        {
            int index;
            do
            {
                index = random.Next(Words.Count);
            } while (Words[index].IsHidden);

            Words[index].Hide();
        }
    }

    public override string ToString()
    {
        var scriptureText = string.Join(' ', Words);
        return $"{Reference}\n{scriptureText}";
    }

    public bool AllWordsHidden()
    {
        return Words.TrueForAll(word => word.IsHidden);
    }
}
