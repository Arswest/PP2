using System;
using System.IO;
using System.Threading.Tasks;

namespace Packman2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"input.txt");
            string s = sr.ReadToEnd();
            string[] arr = s.Split();
            int n = int.Parse(arr[0]);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        public static void Move(int x, int y)
        {

           
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            while (true)
            {
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    y--;
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    y++;
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    x++;
                }
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    x--;
                }

            }
      

        }


    }
}
