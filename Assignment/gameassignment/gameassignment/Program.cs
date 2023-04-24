
Console.WriteLine("Enter No. of Robbers: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter The Robber with whom Sam will start shooting: ");
int s = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the gap between the robbers: ");
int g = Convert.ToInt16(Console.ReadLine());
int[] robbers = new int[n];
int CurrentIndex = s - 1;
int ShotsCompleted = 0;
for (int i = 0; i < n; i++)
{
    robbers[i] = i + 1;
}
while (n != 0)
{
    if (CurrentIndex >= n)
    {
        CurrentIndex = CurrentIndex % n;
    }
    Console.WriteLine($"Target = {robbers[CurrentIndex]} , {++ShotsCompleted} shots completed");
    for (int i = CurrentIndex; i < n - 1; i++)
    {
        robbers[i] = robbers[i + 1];
    }
    n--;
    CurrentIndex += g;
}
Console.WriteLine(ShotsCompleted + " shots taken");

