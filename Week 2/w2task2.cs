using System;

    public class Car
    {
        public string model = " ";
        public int price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.model = "BMW";
            c1.price = 20;

            Car c2 = new Car();
            c2.model = "ferrari";
            c2.price = 90;

            Car c3 = c1;
            c3.price = 30;

        Car c4 = new Car();
        c4.model = c2.model;
        c4.price = c1.price;

        Console.WriteLine(c1.price);
        Console.WriteLine(c2.price);
        Console.WriteLine(c3.price);
        Console.WriteLine(c4.price);
        Console.WriteLine(c4.model);


        Console.ReadKey();

        }
    }
