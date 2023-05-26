public class Words
{
    private List<string> _words = new List<string>();
    private List<int> _wordsindex = new List<int>();
    private bool _hidden = false;

    public Words(string verse)
    {
        _words = verse.Split().ToList<string>();
        for (int i = 0; i < _words.Count; i++)
        {
            _wordsindex.Add(i);
        }
    }

    public List<string> GetVerse()
    {
        return _words;
    }

    public List<int> GetIndex()
    {
        return _wordsindex;
    }

    public bool GetHidden()
    {
        return _hidden;
    }


    public void SetVerse(string verse)
    {
        string[] words = verse.Split();
        foreach (string word in words)
        {
            _words.Add(word);
        }
    }

    public void HideWord()
    {
        Random rnd = new Random();
        var index = rnd.Next(_wordsindex.Count);

        
        if (_words[_wordsindex[index]] != "_")
        {
            _words[_wordsindex[index]] = "_";
            _wordsindex.RemoveAt(index);
        }

        if (_wordsindex.Count == 0)
        {
            _hidden = true;
        }
    }
}