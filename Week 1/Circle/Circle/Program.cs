using System;


namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle C = new Circle();
            Console.WriteLine(C);
            Console.WriteLine(C.findArea());
            Console.WriteLine(C.findCircumreference());
            Console.WriteLine(C.findDiameter());
        }
    }
}