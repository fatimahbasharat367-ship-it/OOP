string line;
Console.Write("Please Enter your name : ");
line = Console.ReadLine() ?? " ";
Console.Write("Welcome ");
Console.Write(line);
Console.Write("!");
Console.ReadKey();