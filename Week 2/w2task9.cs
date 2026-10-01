using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

    public class Student
    {
        public string Name = " ";
        public float EcatMarks;
        public float matricMarks;
        public float Aggregate;


        public Student()
        {

        }

        public Student(Student sample)
        {
            Name = sample.Name;
            EcatMarks = sample.EcatMarks;
            matricMarks = sample.matricMarks;
            Aggregate = sample.Aggregate;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Student hehe = new Student();
            hehe.Name = "Fatimah";
            hehe.EcatMarks = 5;
            hehe.matricMarks = 78;
            hehe.EcatMarks = 67;

            Student hihi = new Student();
            hihi.Name = "Alishba";

            Console.WriteLine(hihi.Name);
            Console.WriteLine(hehe.Name);

            Console.ReadKey();
        }

    }
}