namespace Exercise.CSharp.Delegates;

public static class ExecuteMultiCastDemo
{
    public static void Execute()
    {
        StrMod strOp;
        StrMod replaceSp = MultiCastDemo.ReplaceSpaces;
        StrMod removeSp = MultiCastDemo.RemoveSpaces;
        StrMod reverseStr = MultiCastDemo.Reverse;
        string str = "OnlyText";

        strOp = replaceSp;
        strOp += reverseStr;
        strOp(ref str);
        Console.WriteLine(str);
    }
}