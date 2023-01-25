using System.Globalization;

var arr = new string[5, 5]
{
    {"1","2","3","4","5"},
    {"6","7","8","9","10"},
    {"11","12","13","14","15"},
    {"16","17","18","19","20"},
    {"21","22","23","24","25"}
};

int k = 1;
 while(k <= 10)
{
    Console.WriteLine("Enter the seat number:");
    string seatNum = Console.ReadLine();
    Console.WriteLine("\nChoose food preference: Veg/Non-Veg");
    string pref = Console.ReadLine();
    for (int i = 0; i < 5; i++)
    {
        for(int j = 0; j < 5; j++)
        {
            if (arr[i,j] == seatNum)
            {
                arr[i, j] = seatNum + " :" + pref;
            }
        }
    }
    k++;
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(arr[i,j] + "\t");
    }
    Console.WriteLine();
}