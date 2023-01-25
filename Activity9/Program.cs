var DateInpArr = new string[10];
Console.WriteLine("Type in your Date of birth:");
for (int i = 0; i < 10; i++)
{
    DateInpArr[i] = Console.ReadLine();
}
foreach (var i in DateInpArr)
{
    ShowDatesFormats(i);
}
void ShowDatesFormats(string element)
{
    var Today = DateTime.Today;
    var MyDate = Convert.ToDateTime(element);
    var Day = (Today - MyDate).TotalDays;
    int DaysInt = (int)Day;
    int Age = DaysInt / 365; 
    if (Age != 0 && Age < 100)
    {
        if (Age < 10)
        {
            Console.WriteLine($"{element} - You are {Age} years old - Kid");
        }
        else if (Age > 10 && Age < 30)
        {
            Console.WriteLine($"{element} - are {Age} years old - Youth");
        }
        else if (Age > 30 && Age < 60)
        {
            Console.WriteLine($"{element} - You are {Age} years old - Adult");
        }
        else if (Age > 60 && Age < 100)
        {
            Console.WriteLine($"{element} -You are {Age} years old - Older");
        }
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}