using System;

namespace Student
{
    class Student
    {
        string name;
        string sname;
        double gpa;
        public Student(string n, string s, double g)
        {
            name = n;
            sname = s;
            gpa = g;
        }

        public override string ToString()
        {
            return this.sname + " " + this.name + " " + this.gpa;
        }
    }
    class Program
    {
        static int Main(string[] args)
        {

            Student s = new Student("Derbes", "Utebaliyev", 3.33);
            Console.WriteLine(s);



            Student s1 = new Student(Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine()));
            Console.WriteLine(s1);

            return 0;
        }
    }
}