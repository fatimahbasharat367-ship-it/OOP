using System;

public class Course
{
    public string title = " ";
    public int credits;
    public int code;



    public Course()
    {

    }

    public Course(Course sample)
    {
        title = sample.title;
        credits = sample.credits;
        code = sample.code;

    }
}

class Program
{
    static void Main(string[] args)
    {
        Course c1 = new Course();
        c1.title = "OOP";
        c1.credits = 3;
        c1.code = 101;

        Course c2 = new Course();
        c2.title = "Data Structure";
        c2.credits = 4;
        c2.code = 201;

        Course c3 = new Course(c2);

        Console.WriteLine(c1.title + " - " + c1.credits + " - " + c1.code);
        Console.WriteLine(c2.title + " - " + c2.credits + " - " + c2.code);
        Console.WriteLine(c3.title + " - " + c3.credits + " - " + c3.code);

        Console.ReadKey();
    }
}