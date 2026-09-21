//Mine Calculatorrrrrrrrrrrrrrrrrrrrrrrrr
Console.Write("Enter the Number 1 : ");
int n1 = int.Parse(Console.ReadLine() ?? " ");
Console.Write("Enter the Number 2 : ");
int n2 = int.Parse(Console.ReadLine()?? " ");


Console.WriteLine("Which calculation do you want : ");
Console.WriteLine(" 1 : Addition ");
Console.WriteLine(" 2 : Subtraction ");
Console.WriteLine(" 3 : Multiplication ");
Console.WriteLine(" 4 : Division ");
int choice = int.Parse(Console.ReadLine() ?? "");

if (choice == 1)
{
    int sum = n1 + n2;
    Console.Write("The Sum of numbers is " + sum);
}
else if (choice == 2)
{
    int sub = n1 - n2;
    Console.Write("The Subtraction of numbers is " + sub);
}
else if (choice == 3)
{
    int multi = n1 * n2;
    Console.Write("The Multiplication of numbers is " + multi);
}
else if (choice == 4)
{
    int div = n1 / n2;
    Console.Write("The Division of numbers is " + div);
}
else
{
    Console.Write("The number you dial is busy at the moment plz try again later hehe ");
}
