string str = "123456";

float number;

try
{
    number = float.Parse(str);
    Console.WriteLine(number);

}
catch (FormatException)
{
    number = -6;
    Console.WriteLine(number);
}