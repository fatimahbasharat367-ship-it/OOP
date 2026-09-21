//Problem no 2 : ( Short Method )
Console.Write("Enter your Height : ");
int h = int.Parse(Console.ReadLine() ?? " ");
Console.Write("Enter your age : ");
int age = int.Parse(Console.ReadLine() ?? " ");

int weight = age + h;
Console.WriteLine("Your weight is : " + weight);