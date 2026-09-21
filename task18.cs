Console.Write("Enter your name : ");
string name = Console.ReadLine() ?? " ";

for (int i = 0; i < 5; i++)
{
    Console.Write("Hi ");
    Console.WriteLine(name);
}