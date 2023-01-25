Console.WriteLine("Enter 000 to quit and display the items");
Console.WriteLine("\nEnter array elements:");

List<int> list = new List<int>();

do
{
    int element = Convert.ToInt32(Console.ReadLine());

    if (element == 000)
    {
        Display();
        break;
    }
    else
    {
        list.Add(element);
    }
} while (true);

void Display()
{
    foreach (var i in list)
    {
        Console.WriteLine(i);
    }

}