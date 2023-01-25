int weightDiff; 
string[] boardPass = new string[5];
int[] weight = new int[5];
int[] weightDiffArray = new int[weight.Length]; 
for (int i = 0; i < boardPass.Length; i++)
{
    Console.WriteLine("Enter your name");
    string name = Console.ReadLine();
    boardPass[i] = name;
    Console.WriteLine("\nWeight:\n");
    int weightElement = Convert.ToInt32(Console.ReadLine());
    weight[i] = weightElement;
}
Console.WriteLine("\n");
for (int i = 0; i < boardPass.Length; i++)
{
    Console.WriteLine("Name - {0}", boardPass[i]);
    Console.WriteLine("Weight - {0}kg", weight[i]);
    Console.WriteLine($"Weight Charge {weightFun(weight[i])}$");
    weightDiffArray[i] = weightFun(weight[i]);
    Console.WriteLine("\n");
}
int weightFun(int weight)
{
    int weightDiffInFun = (weight - 23);
    if (weightDiffInFun > 0)
    {
        return (20 + (weightDiffInFun * 15));
    }
    else
    {
        return 20;
    }
}
Console.WriteLine("Descending Overweight fare:");
Array.Sort(weightDiffArray);
for (int i = (weightDiffArray.Length - 1); i >= 0; i--)
{
    Console.WriteLine($"{weightDiffArray[i]}$");
}