using System;
using System.Net.NetworkInformation;

public class Book
{
    public string title = " ";
    public int pages;
    public int id;

}

class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book();
        b1.title = "C# Basics";
        b1.pages = 200;
        b1.id = 1;

        Book b2 = b1;
        b2.pages = 300;

        Console.WriteLine(b1.id);
        Console.WriteLine(b1.title);
        Console.WriteLine(b1.pages);

        Console.ReadKey();
    }
}