public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(word));
        }
    }

    // Hides up to 'count' words, choosing only from words that are still visible
    public void HideRandomWords(int count)
    {
        List<Word> visible = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < count && visible.Count > 0; i++)
        {
            int index = _random.Next(visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public int GetWordCount()
    {
        return _words.Count;
    }

    public int GetHiddenCount()
    {
        return _words.Count(w => w.IsHidden());
    }

    public string GetDisplayText()
    {
        string words = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {words}";
    }
}