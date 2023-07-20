namespace Exercise.CSharp.ThreeWhales;

public class ListsOfElementsOfAnonymousType
{
    public void ListOfElementsWithANonymousType()
    {
        //a list of elements of an anonymous type
        List<int> list = new List<int>();
        var x = new { Name = "Saba", Age = 24 };

        var arr = new[] { x };
        var listOfElementsAnonymous = arr.ToList();
    }
}