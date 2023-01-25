Console.WriteLine("1.Sorting");
Console.WriteLine("2.Reverse Sorting");
Console.WriteLine("3.Search");
Console.WriteLine("4.Minimum Fare");
Console.WriteLine("5.Maximum Fare");
Console.WriteLine("6.Duplicate ");

double[] array = new double[10];
double temp = 0;
Console.WriteLine("Enter the elements\n");



for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
}

//sorting

for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[i])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

int f = 1;
do
{
    Console.WriteLine("\nEnter the function:\n");
    int element = Convert.ToInt32(Console.ReadLine());
    switch (element)
    {
        case 1:
            sortingFun();
            break;
        case 2:
            revSortingFun();
            f = 1;
            break;
        case 3:
            searchFun();
            break;
        case 4:
            minimumVal();
            break;
        case 5:
            maximumVal();
            break;
        case 6:
            duplicate();
            break;
        default:
            f = 0;
            break;

    }
}
while (f == 1);
void sortingFun()
{

    // after sorting
    Console.WriteLine("\nafter sorting\n");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

}
void revSortingFun()
{
    Console.WriteLine("\nAfter Reverse sorting\n");
    for (int i = array.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(array[i]);
    }
}

void searchFun()
{
    Console.WriteLine("\n enter the search element");
    double searchVal = Convert.ToDouble(Console.ReadLine());
    int count = 0;
    foreach (var item in array)
    {
        if (item == searchVal)
        {
            count++;
        }
    }
    if (count > 0)
    {
        Console.WriteLine($"{searchVal} found {count} times");
    }
    else
    {
        Console.WriteLine("sorry not found");
    }
}

void minimumVal()
{
    Console.WriteLine("minimum value = {0}", array[0]);
}

void maximumVal()
{
    Console.WriteLine("maximum value = {0}", array[(array.Length) - 1]);
}

void duplicate()
{
    bool found = false;

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] == array[i])
            {
                found = true;
                Console.WriteLine($"{array[i]} at position {i + 1} and {j + 1}");
            }


        }
    }
    if (!found)
    {
        Console.WriteLine("\n Duplicate not found\n");
    }
}



