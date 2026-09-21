static int add(int a, int b)
{
    int c;
    c = a + b;
    return c;
}

Console.Write("Enter 1st Number : ");
int num1 = int.Parse(Console.ReadLine()?? " ");
Console.Write("Enter 2nd Number : ");
int num2 = int.Parse(Console.ReadLine() ?? " ");
int addition;
addition = add(num1, num2);
Console.Write("The sum of the two numbers is : ");
Console.WriteLine(addition);
