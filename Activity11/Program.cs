var OddList = new List<int>();
var EvenList = new List<int>();
for (int i = 100; i < 111; i++)
{
    if (i % 2 == 0)
    {
        EvenList.Add(i);
    }
    else
    {
        OddList.Add(i);
    }
}
Console.WriteLine("Enter \"x\" to Quit\n");
bool LoopOn = true;
do
{
    Console.WriteLine("\nEnter the alphabet\n");
    char FlightAlpha = Convert.ToChar(Console.ReadLine());
    switch (FlightAlpha)
    {
        case 'F' or 'f':
            foreach (int i in OddList)
            {
                Console.WriteLine($"F{i}");
            }
            break;
        case 'w' or 'W':
            foreach (int i in EvenList)
            {
                Console.WriteLine($"W{i}");
            }
            break;
        case 'q' or 'Q':
            for (int i = 101; i <= 200; i++)
            {
                if (PrimeNumbersFun(i) == 0)
                {
                    Console.WriteLine($"Q{i}");
                }
            }
            break;
        case 'n' or 'N':
            Fibonnacci();
            break;
        case 'a' or 'A':
            ArmStrong();
            break;
        case 'x' or 'X':
            LoopOn = false;
            break;
    }
} while (LoopOn);
int PrimeNumbersFun(int num)
{
    int count = 0; 
    if (num % 2 == 0)
    {
        count++;
        return count;
    }
    else
    {
        for (var j = 2; j < num / 2; j++)
        {
            if (num % j == 0)
            {
                count++;
            }
        }
        return count;
    }
}
void Fibonnacci()
{
    int t1 = 0;
    int t2 = 1;
    int nextTerm = 0;
    Console.WriteLine($"N{t1}");
    Console.WriteLine($"N{t2}");
    for (int i = 0; i < 10; i++)
    {
        nextTerm = t1 + t2;
        t1 = t2;
        t2 = nextTerm;
        Console.WriteLine($"N{nextTerm}");
    }
}
void ArmStrong()
{
    int t;
    int sum;
    int SNumber;
    for (int i = 1; i < 500; i++)
    {
        if (i < 10)
        {
            Console.WriteLine($"A{i}");
        }
        else
        {
            t = i;
            sum = 0;
            while (t != 0)
            {
                SNumber = t % 10;
                sum += SNumber * SNumber * SNumber;
                t = t / 10;
            }
            if (sum == i)
            {
                Console.WriteLine($"A{i}");
            }
        }
    }
}