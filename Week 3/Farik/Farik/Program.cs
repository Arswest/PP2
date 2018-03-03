using System;


namespace Farik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 58);
            Realisation far = new Realisation(@"Example");

            bool quit = false;

            while (!quit)
            {
                far.Print();
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.Escape:
                        quit = true;
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.Backspace:
                    case ConsoleKey.Enter:
                        far.Process(pressedKey);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}