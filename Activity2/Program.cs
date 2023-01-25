double fare;
double bookingTime;
double chargedFare = 0;
Console.WriteLine("Enter Fare:\n");
fare = double.Parse(Console.ReadLine());
//Console.WriteLine(fare);
Console.WriteLine("Enter booking time in 24 hour format:\n");
bookingTime = double.Parse(Console.ReadLine());
if (bookingTime >= 6 && bookingTime <= 9)
{
    chargedFare = fare + (fare * 0.1);
    Console.WriteLine("\nAmount: \n" + chargedFare);

}
else if (bookingTime > 9 && bookingTime <= 17)
{
    chargedFare = fare + (fare * 0.2);
    Console.WriteLine("\nAmount: \n" + chargedFare);
}
else if (bookingTime > 17 && bookingTime <= 23)
{
    chargedFare = fare + (fare * 0.7);
    Console.WriteLine("\nAmount: \n" + chargedFare);
}
else
{
    chargedFare = fare + (fare * 0.5);
    Console.WriteLine("\nAmount: \n" + chargedFare);
}
