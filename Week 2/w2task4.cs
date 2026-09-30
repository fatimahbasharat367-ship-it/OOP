using System;
public class Mobile
{
    public string name = " ";
    public int price;

}

class Program
{
    static void Main(string[] args)
    {
        Mobile m1 = new Mobile();
        m1.name = "Samsung";
        m1.price = 100;

        Mobile m2 = new Mobile();
        m2.name = "iphone";
        m2.price = 200;

        m2.price = 500;
        m1.price = m2.price;
        //m2.price = 500;

        Console.WriteLine(m1.price);
        Console.WriteLine(m2.price);

    }
}