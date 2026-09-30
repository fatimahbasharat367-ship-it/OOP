using System;

public class Product
{
    public string name = " ";
    public int price;
    public int stock;

}

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product();
        p1.name = "Gaming Laptop";
        p1.price = 50000;
        p1.stock = 8;

        Product p2 = new Product();
        p2.name = p1.name;
        p2.price = p1.price;
        p2.stock = p1.stock;

        Product p3 = p1;

        Console.WriteLine(p1.name + " - " + p1.price + " - " + p1.stock);
        Console.WriteLine(p2.name + " - " + p2.price + " - " + p2.stock);
        Console.WriteLine(p3.name + " - " + p3.price + " - " + p3.stock);

        Console.ReadKey();
    }
}