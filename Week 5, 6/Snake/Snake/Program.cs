using System;

using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GameInit();
            while (true)
            {

                if (Game.snake.EatFood())
                {
                    Game.food.FoodGenerate();
                    Game.food.Draw();
                    Game.snake.Grow();
                }
                if (Game.snake.EatBody() || Game.snake.EatWalls())
                {
                    Environment.Exit(0);
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo btn = Console.ReadKey();
                    Game.snake.HandleDirection(btn);
                }
                Game.snake.Move();
                Game.snake.Draw();
                Thread.Sleep(200);
            }
        }
    }
}