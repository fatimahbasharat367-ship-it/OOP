Console.Write("Enter of which numbr you want to print the table : ");
int n = int.Parse(Console.ReadLine() ?? " ");
int num = 10;
for ( int i = 1; i < num+1; i++)
{
    int table;
    table = n * i;
    Console.WriteLine(table);
    Console.Read();
}