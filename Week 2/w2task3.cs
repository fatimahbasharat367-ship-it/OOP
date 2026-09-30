using System;

public class Laptop
{
    public string brand = "";
    public int ram;
}

class Program
{
    static void Main(string[] args)
    {
      Laptop l1 = new Laptop();
        l1.brand = "del";
        l1.ram = 8;

        Laptop l2 = new Laptop();
        l2.brand = "hp";
        l2.ram = 16;

        Laptop l3 = l1;
        l3.ram = 32;
        l1.brand = l2.brand;

        Console.WriteLine(l1.brand + " - " +  l1.ram );
        Console.WriteLine(l2.brand + " - " +  l2.ram );
        Console.WriteLine(l3.brand + " - " + l3.ram);
    }
}