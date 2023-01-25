string[] nameArray = new string[2];
string[] destinationArray = new string[2];

Console.WriteLine("\nEnter Your name:\n");

for (int i = 0; i < 2; i++)
{
    nameArray[i] = Console.ReadLine();
}


Console.WriteLine("\nEnter Destination:\n");
for (int i = 0; i < 2; i++)
{
    destinationArray[i] = Console.ReadLine();
}

var arr = new string[nameArray.Length]; 
for (int i = 0; i < nameArray.Length; i++)
{
    arr[i] = $"{nameArray[i]} : {destinationArray[i]}";
}
foreach (var item in arr)
{
    Console.WriteLine(item);
}