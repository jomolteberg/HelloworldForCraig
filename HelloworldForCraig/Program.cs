// See https://aka.ms/new-console-template for more information
string name = "John";
Console.WriteLine($"Hello, {name}!");


Console.WriteLine(string.Join(" ", CountTo(10)));

static List<int> CountTo(int num)
{
    List<int> numbers = [];
    for (int i = 1; i <= num; i++)
    {
        numbers.Add(i);
    }
    return numbers;
}