Console.WriteLine("Store the array elements in odd or even positions");
double[] myArray = new double[10];
double[] myArray2 = new double[20];


Console.WriteLine("\nEnter elements:\n");
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = Convert.ToDouble(Console.ReadLine());
}
int j = -1;
for (int i = 0; i < myArray.Length; i++)
{
    if ((int)myArray[i] % 2 != 0)
    {
        j += 2;
        myArray2[j] = myArray[i];
    }

}
int p = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if ((int)myArray[i] % 2 == 0)
    {
        p += 2;
        myArray2[p] = myArray[i];
    }
}
Console.WriteLine("\n Elements in order:\n");
foreach (var item in myArray2)
{
    Console.WriteLine(item);
}

