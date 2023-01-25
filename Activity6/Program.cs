using System.Diagnostics;
using Activity6;

Random rnd = new Random();
string[] locations = new string[] { "Thrissur", "Palakkad", "Ernakulam", "Kannur", "Kozhikode" };
List<string> lst = new List<string>();
for (int i = 0; i < locations.Length; i++)
{
    for (int j = i + 1; j < locations.Length; j++)
    {
        lst.Add($"s{i}{j}");
    }
}
var PeopleArray = new Travel[lst.Count];
int z = 0;
for (int i = 0; i < locations.Length; i++)
{
    for (int j = i + 1; j < locations.Length; j++)
    {
        int num = rnd.Next(800, 1000);
        int short_path = rnd.Next(300, 800);
        int fair = rnd.Next(150, 300);
        int fair_short = rnd.Next(10, 150);
        PeopleArray[z] = new Travel(locations[i], locations[j], num, short_path, fair, fair_short);
        z++;
    }
}
Console.WriteLine("\nEnter the starting location:\n");
var start = Console.ReadLine();
Console.WriteLine("\nEnter the ending location:\n");
var end = Console.ReadLine();
int l;
do
{
    Console.WriteLine("1. Shortest path finding");
    Console.WriteLine("2. Longest path finding");
    Console.WriteLine("3. Lowest fare finding");
    Console.WriteLine("4. Highest fare finding");
    Console.WriteLine("5. Shortest path and lowest fare finding");
    Console.WriteLine("6. Shortest path and highest fare finding");
    Console.WriteLine("7. Longest path and lowest fare finding");
    Console.WriteLine("8. Longest path and highest fare finding");
    var switch_on = Console.ReadLine();
    switch (switch_on)
    {
        case "1":
            shorest_path(PeopleArray, start, end);
            break;
        case "2":
            longest_path(PeopleArray, start, end);
            break;
        case "3":
            low_fair(PeopleArray, start, end);
            break;
        case "4":
            high_fair(PeopleArray, start, end);
            break;
        case "5":
            Short_Path_Lfair(PeopleArray, start, end);
            break;
        case "6":
            Short_path_Hfair(PeopleArray, start, end);
            break;
        case "7":
            longest_path_Hfair(PeopleArray, start, end);
            break;
        case "8":
            longest_path_Lfair(PeopleArray, start, end);
            break;
        default:
            break;
    }
    Console.WriteLine("\nDo you want to continue press 1\n");
    l = int.Parse(Console.ReadLine());
} while (l == 1);
static void shorest_path(Travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("\nThe shortest path is : \n" + PeopleArray[i].short_path + "Km");
        }
    }
}
static void longest_path(Travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("\nThe longest path is : \n" + PeopleArray[i].path + "Km");
        }
    }
}
static void low_fair(Travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("\nThe lowest fare is : \n" + PeopleArray[i].fair_short + "Rs");
        }
    }
}
static void high_fair(Travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("\nThe highest fare is : \n" + PeopleArray[i].fair + "Rs");
        }
    }
}
static void Short_Path_Lfair(Travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("\nThe shortest path is : \n" + PeopleArray[i].short_path + "Km");
            Console.WriteLine("\nThe lowest fare is : \n" + PeopleArray[i].fair_short + "Rs");
        }
    }
}
static void Short_path_Hfair(Travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("\nThe shortest path is : \n" + PeopleArray[i].short_path + "Km");
            Console.WriteLine("\nThe higest fare : \n" + PeopleArray[i].fair + "Rs");
        }
    }
}
static void longest_path_Hfair(Travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("\nThe longest path is : \n" + PeopleArray[i].path + "Km" );
            Console.WriteLine("\nThe shortest fare is : \n" + PeopleArray[i].fair_short + "Rs");
        }
    }
}
static void longest_path_Lfair(Travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("\nThe longest path is : \n" + PeopleArray[i].path + "Km" );
            Console.WriteLine("\nThe lowest fare is : \n" + PeopleArray[i].fair_short + "Rs");
        }
    }
}