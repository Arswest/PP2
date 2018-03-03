using System;
using System.IO;

namespace Maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = File.ReadAllText(@"EmptyClass.txt");
            string[] values = line.Split(' ');
            int min = 1000;
            int max = -1;
            for (int i = 0; i < values.Length; i++)
            {
                if (int.Parse(values[i]) > max) max = int.Parse(values[i]);
                if (int.Parse(values[i]) < min) min = int.Parse(values[i]);
            }
     
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
