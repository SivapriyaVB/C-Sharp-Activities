var today = DateTime.Today;

Console.WriteLine("Enter dob (YYYY:MM:DD format)");
var Bday = Console.ReadLine();
var myDate = Convert.ToDateTime(Bday);
var day = (today - myDate).TotalDays;
int daysInt = (int)day;
int age = daysInt / 365;
int ageHours = daysInt * 24;
int ageWeeks = daysInt / 7;
int ageMonths = age * 12;


Console.WriteLine($"You are {age} years old");
Console.WriteLine($"You are {ageHours} Hours old");
Console.WriteLine($"You are {daysInt} days old");
Console.WriteLine($"You are {ageWeeks} Weeks old");
Console.WriteLine($"You are {ageMonths} Months old");

if ((myDate.Year) % 4 == 0)
{
    Console.WriteLine("leap year");
}
else
{
    Console.WriteLine("not a leap year");
}