using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serialization 
{

    class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("lb4.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Complex ans = bf.Deserialize(fs) as Complex;

            Console.WriteLine(ans);
            string line = Console.ReadLine();

            string[] s = line.Split(' ');
            string[] n1 = s[0].Split('/');
            string[] n2 = s[1].Split('/');
            int a = int.Parse(n1[0]);
            int b = int.Parse(n1[1]);
            int c = int.Parse(n2[0]);
            int d = int.Parse(n2[1]);

            Complex c1 = new Complex(a, b);
            Complex c2 = new Complex(c, d);


            Complex dif = c1 / c2;
            Complex mult = c1 * c2;
            Complex sum = c1 + c2;
            Complex minus = c1 - c2;

            bf.Serialize(fs, sum);
      
            fs.Close();
            Console.WriteLine(sum);

            Console.ReadKey();

        }
    }
}