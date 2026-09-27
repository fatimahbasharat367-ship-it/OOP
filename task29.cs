Console.Write("Enter your Age : ");
int marks = int.Parse(Console.ReadLine() ?? " ");
if (marks >= 18)
{
    Console.Write("You can Vote.");
}else
{
    Console.Write("You can't Vote. ");
}