int[] number = new int[5];

Console.Write("Enter 1st Number : ");
int num1 = int.Parse(Console.ReadLine()?? "");

Console.Write("Enter 2nd Number : ");
int num2 = int.Parse(Console.ReadLine()?? " ");


Console.Write("Enter 3rd Number : ");
int num3 = int.Parse(Console.ReadLine()?? "");

if (num1 > num2 && num1 > num3)
{
    Console.Write("Number 1 is Greater. ");
}
else if (num2 > num3 && num2 > num1)
{
    Console.Write("Number 2 is Greater. ");
}
else
{
    Console.Write("Number 3 is Greater. ");
}