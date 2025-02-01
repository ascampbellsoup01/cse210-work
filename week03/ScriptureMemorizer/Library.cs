public class Library
{
    private List<Scripture> _scriptures;

    public Library()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Doctrine and Covenants", 14, 7), "And, if you keep my commandments and endure to the end you shall have eternal life, which gift is the greatest of all the gifts of God."),
        };
    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
