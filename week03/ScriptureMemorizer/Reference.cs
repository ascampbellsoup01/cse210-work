public class Reference
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int VerseStart { get; set; }
    public int VerseEnd { get; set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verse;
        VerseEnd = verse;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verseStart;
        VerseEnd = verseEnd;
    }

    public override string ToString()
    {
        return VerseStart == VerseEnd ? $"{Book} {Chapter}:{VerseStart}" : $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
    }
}
