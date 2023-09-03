//{ { "aaa" }, { "bbb" }, { "ccc" } } => { { "aaa" }, { "bbb" }, { "ccc" } }
//{ { "aaa", "bbb" }, { "aaa", "bbb", "ccc" }, { "aaa", "bbb", "ccc", "ddd" } } => { { "aaa", "bbb" }, { "ccc" }, { "ddd" } }
//{ { "aaa-bbb", "ccc-aaa" }, { " bbb-ddd ", "ddd - aaa", " eee - fff " } }
//  => { { "aaa", "bbb", "ccc" }, { "ddd", "eee", "fff" } }

static string[][] GetUniqueWordsArray(IEnumerable<string> lines, char separator)
{
    List<string[]> result = new List<string[]>();
    List<string> uniqueWordsSet = new List<string>();

    foreach (string line in lines)
    {
        string[] words = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        List<string> uniqueWords = new List<string>();

        foreach (string word in words)
        {
            string trimmedWord = word.Trim();
            // Check if the word is not already in the uniqueWordsSet
            if (!uniqueWordsSet.Contains(trimmedWord))
            {
                uniqueWordsSet.Add(trimmedWord);
                uniqueWords.Add(trimmedWord);
            }
        }
        
        if (uniqueWords.Count > 0)
        {
            result.Add(uniqueWords.ToArray());
        }
    }

    return result.ToArray();
}

string[] inputLines = new string[] { "aaa-bbb-aaa", "ccc-aaa", " bbb-ddd ", "ddd - aaa", " eee - fff " };
char separator = '-';

var result = GetUniqueWordsArray(inputLines, separator);

var s = 5 + 5;