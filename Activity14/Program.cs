var FlightSeatArr = new string[5, 5];
int NumberOfSeats;
int AvailableSeats;
char Option;
bool LoopOn = true;
int count = 0;
int limiter = 0; 

Console.WriteLine("1.Booking");
Console.WriteLine("Enter \"Q\" to  exit");

do
{
    Console.WriteLine("\nEnter the option");
    Option = Convert.ToChar(Console.ReadLine());
    switch (Option)
    {
        case '1':
            SeatBookingFun();
            break;
        case 'q' or 'Q':
            LoopOn = false;
            break;
    }
} while (LoopOn);
void SeatBookingFun()
{
    Console.WriteLine("\nEnter the number of seats you want to book:"); 
    NumberOfSeats = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nEnter the boarding pass number"); 
    if (NumberOfSeats >= 5)
    {
        for (int i = 0; i < 5; i++)
        {
            if (limiter >= 5)
            {
                break;
            }
            AvailableSeats = 0; for (int j = 0; j < 5; j++)
            {
                if (FlightSeatArr[i, j] == null)
                {
                    AvailableSeats++;
                }
            }
            if (AvailableSeats == 5)
            {
                for (int j = 0; j < 5; j++)
                {
                    FlightSeatArr[i, j] = Console.ReadLine();
                    limiter++;
                }
            }
        }
    }
    else
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (count == NumberOfSeats)
                {
                    break;
                }
                if (FlightSeatArr[i, j] == null)
                {
                    FlightSeatArr[i, j] = Console.ReadLine();
                    count++;
                }
            }
        }
        count = 0;
    }
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("\n");
        for (int j = 0; j < 5; j++)
        {
            if (FlightSeatArr[i, j] == null)
            { Console.Write(" NB "); }
            else
            { Console.Write($" {(FlightSeatArr[i, j])} "); }
        }
    }
}