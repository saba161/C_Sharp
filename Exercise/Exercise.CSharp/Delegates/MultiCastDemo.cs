namespace Exercise.CSharp.Delegates;

delegate void StrMod(ref string str);

public class MultiCastDemo
{
    public static void ReplaceSpaces(ref string s)
    {
        Console.WriteLine("Замена пробелов дефисами.");
        s = s.Replace(' ', '-');
    }

    public static void RemoveSpaces(ref string s)
    {
        string temp = "";
        int i;
        Console.WriteLine("Удаление пробелов.");
        for (i = 0; i < s.Length; i++)
            if (s[i] != ' ')
                temp += s[i];
        s = temp;
    }

    public static void Reverse(ref string s)
    {
        string temp = "";
        int i, j;
        Console.WriteLine("Обращение строки.");
        for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
            temp += s[i];
        s = temp;
    }
}