using System;
using System.IO;


namespace MinPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = File.ReadAllText(@"input.txt");
            string[] values = line.Split(' ');
            int min = 10000;
            int index = 0;
            for (int i = 0; i < values.Length; i++)
            {
                int crt = int.Parse(values[i]);
                if(crt<min&&Prime(crt)==true)
                {
                    min = crt;
                    index = i;
                }
               
            }
            File.WriteAllText(@"output.txt", values[index]);
        }
        static bool Prime(int a)
        {
            if (a == 1) return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
    }
}