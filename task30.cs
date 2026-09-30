Console.Write("Enter your Marks : ");
int marks = int.Parse(Console.ReadLine()?? " ");

if( marks > 50)
{
    for (int i = 1; i < marks+1 ; i++)
    {
        Console.WriteLine(i + " " + "Yayyyy ! You are pass. ");
    }
}else
{
    Console.Write("Try Again till you succeed. ");
}