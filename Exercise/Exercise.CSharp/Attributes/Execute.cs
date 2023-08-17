namespace Exercise.CSharp.Attributes;

public static class ExecuteAttribute
{
    public static void Execute()
    {
        TestConditional t = new TestConditional();
        t.Trial(); // called only if identificator TRIAL defined
        t.Release(); // called only if identificator RELEASE defined
    }
}