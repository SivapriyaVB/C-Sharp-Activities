Console.WriteLine("Enter your name:");
string? fName = Console.ReadLine();
Console.WriteLine("\nEnter total miles travelled:\n");
int milesTravelled = Convert.ToInt32(Console.ReadLine());

switch (milesTravelled)
{
    case > 10000 and <= 20000:
        Console.WriteLine("10 Frequent flyer points awarded");
        break;
    case > 20000 and <= 50000:
        Console.WriteLine("20 Frequent flyer points awarded");
        break;
    case > 50000 and <= 100000:
        Console.WriteLine("30 Frequent flyer points awarded");
        break;
    case > 100000:
        Console.WriteLine("50 Frequent flyer points awarded");
        break;
}

