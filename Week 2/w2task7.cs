using System;

public class Student
{
    public string name = " ";
    public int age;
    public int id;
    public int marks;



    public Student()
        {

       }

    public Student(Student sample)
    {
        name = sample.name;
        age = sample.age;
        id = sample.id;
        marks = sample.marks;

    }

}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.name = "Ahmad";
        s1.age = 15;
        s1.id = 1;
        s1.marks = 100;

        Student s2 = new Student(s1);
        s2.name = "Sania";
        s2.id = 2;


        Console.WriteLine(s1.id);
        Console.WriteLine(s1.name);
        Console.WriteLine(s1.age);
        Console.WriteLine(s1.marks);

        Console.WriteLine(s2.id);
        Console.WriteLine(s2.name);
        Console.WriteLine(s2.age);
        Console.WriteLine(s2.marks);

        Console.ReadKey();
    }
}