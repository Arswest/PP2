using System;
namespace Snake
{  
    class Game
    {
        static public Snake snake;
        static public Walls walls;
        static public Food food;
        public Game()
        {
            snake = new Snake();
            walls = new Walls();
            food = new Food();
            walls.GenerateWalls();
            food.FoodGenerate();
        }
        public void GameInit()
        {
            Console.CursorVisible = false;
            Console.Clear();
            snake.Draw();
            walls.Draw();
            food.FoodGenerate();
            food.Draw();
            snake.AddElements();
        } 
    }
}