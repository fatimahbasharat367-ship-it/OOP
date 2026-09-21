int sum = 0;
int num;

do
{
    Console.Write("Enter koi aur number : ");
    num = int.Parse(Console.ReadLine()?? " ");
    sum = sum + num;
    //Console.WriteLine("The sum of yet inputed numbers is : " + sum);
}
while (num != -1);
Console.WriteLine("-1 enter kr diya. ");
Console.WriteLine("The sum of yet inputed numbers is : " + sum);
Console.ReadKey();