using System;


namespace Snake
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;
        public ConsoleColor color;
        public Point()
        {
            x = 10 / 2;
            y = 10 / 2;
            sym = '*';
            color = ConsoleColor.White;
        }
        public Point(int x, int y, char sym, ConsoleColor color)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
            this.color = color;
        }
        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
            color = p.color;
        }

    }
}