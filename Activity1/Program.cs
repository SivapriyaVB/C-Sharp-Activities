string[] array = new string[10];
string temp;
string searchElement;
int tmp = 0;
int elementPos = 0;
Console.WriteLine("Enter the passenger names:\n");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
}
Console.WriteLine("\nBefore Sorting:\n");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

//Sorting
for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        int greater = string.Compare(array[i].ToLower(), array[j].ToLower());
        if (greater == 1)
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

//Print after sorting

Console.WriteLine("\nSorted Array:\n");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

//Reverse sorting
Console.WriteLine("\nReverse Sorted Array:\n");
for (int i = array.Length - 1; i >= 0; i--)
{
    Console.WriteLine(array[i]);
}

//Search element
Console.WriteLine("\nEnter the element to search:\n");
searchElement = Console.ReadLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == searchElement)
    {
        tmp++;
        elementPos = i + 1;

    }
}
if (tmp > 0)
{
    Console.WriteLine($"{searchElement} is found at position {elementPos} in sorted array");
}
else
{
    Console.WriteLine("Element not found");
}

//Length of array elements

Console.WriteLine("\nLength of each elements:\n");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] + " " + (array[i].Length));
}

//split

Console.WriteLine("\nNames after spliting:\n");
for (int i = 0; i < array.Length; i++)
{
    var splitElement = array[i].Split(' ');
    Array.ForEach(splitElement, i => Console.WriteLine(i));
}

//Duplicate Entries


for (int i = 0; i < array.Length; i++)
{
    int count = 1;
    for (int j = i + 1; j < array.Length; j++)
    {

        if (array[i] == array[j])
            count++;
    }
    if (count > 1)
    {
        Console.WriteLine("\t\n " + array[i] + " occurs " + count + " times");
    }

}
