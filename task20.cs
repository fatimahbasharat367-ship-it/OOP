int sum = 0;
Console.Write("Enter -1 : ");
int num = int.Parse(Console.ReadLine() ?? " ");

while (num != -1)
{


    Console.WriteLine("Enter -1 : ");
    sum += num;
    Console.WriteLine(sum);
    num = int.Parse(Console.ReadLine() ?? " ");
}
Console.Write("You entered -1. ");