namespace Exercise.CSharp.Generics;

public class NonGen
{
    object ob;

    // Передать конструктору ссылку на объект типа object.
    public NonGen(object о)
    {
        ob = о;
    }

    // Возвратить объект типа object.
    public object GetOb()
    {
        return ob;
    }

    // Показать тип переменной ob.
    public void ShowType()
    {
        Console.WriteLine("Тип переменной ob: " + ob.GetType());
    }
}