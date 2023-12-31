namespace Exercise.CSharp.Generics;

public static class ExecuteGenerics
{
    public static void Execute()
    {
        NonGen iOb;

        iOb = new NonGen(102);

        iOb.ShowType();

        int v = (int)iOb.GetOb();
        Console.WriteLine("Значение: " + v);
        Console.WriteLine();
        
        NonGen strOb = new NonGen("Тест на необобщенность");

        // Показать тип данных, хранящихся в переменной strOb.
        strOb.ShowType();

        // Получить значение переменной strOb.
        //Ив этом случае требуется приведение типов.
        String str = (string)strOb.GetOb();
        Console.WriteLine("Значение: " + str);

        // Этот код компилируется, но он принципиально неверный!
        iOb = strOb;

        // Следующая строка кода приводит к исключительной
        // ситуации во время выполнения.
        // v = (int) iOb.GetOb(); // Ошибка при выполнении!
    }
}