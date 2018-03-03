using System;
namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle();
            Console.WriteLine(R);
            Console.WriteLine(R.findArea());
            Console.WriteLine(R.findPerimeter());
            Console.ReadKey();
        }
    }
}