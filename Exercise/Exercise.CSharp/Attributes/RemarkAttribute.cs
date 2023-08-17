#define TRIAL
using System.Diagnostics;

namespace Exercise.CSharp.Attributes;

[AttributeUsage(AttributeTargets.All)]
public class RemarkAttribute : Attribute
{
    string pri_remark;

    public RemarkAttribute(string comment)
    {
        pri_remark = comment;
    }

    public string Remark
    {
        get { return pri_remark; }
    }
}

[Remark("Hii")]
public class UseAttrib
{
}

public class TestConditional
{
    [Conditional("TRIAL")]
    public void Trial()
    {
        Console.WriteLine("Пробная версия, не предназначенная для распространения.");
    }

    [Conditional("RELEASE")]
    public void Release()
    {
        Console.WriteLine("Окончательная рабочая версия.");
    }
}