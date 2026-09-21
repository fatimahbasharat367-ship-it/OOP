Console.Write("Enter your marks : ");
int marks = int.Parse(Console.ReadLine() ?? " ");
if (marks > 50)
{
    Console.WriteLine("You are Pass. ");
    Console.Write("Congratulations ! ");
}
else
{
    Console.WriteLine("Try Again Next ! ");
}