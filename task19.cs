Console.Write("Enter the Number : ");
int num = int.Parse(Console.ReadLine() ?? "");

if (num == -1)
{
    Console.Write("You Entered -1.");
}
else
{
    Console.WriteLine("Enter -1 ");
    int sum = int.Parse(Console.ReadLine() ?? " ");
    sum += num;
    Console.Write(sum);
}
