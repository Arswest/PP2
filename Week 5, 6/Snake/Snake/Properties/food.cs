using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
   
    public class Food
    {
        public Point food;
        public Random random;
        public Food()
        {
            food = new Point();
            random = new Random();
            food.sym = '$';
            food.color = ConsoleColor.DarkBlue;
            FoodGenerate();
        }

        public void FoodGenerate()
        {
            
                food.x = random.Next(3, 9);
                food.y = random.Next(2, 5);
            
        }
        public void Draw()
        {
            food.Draw();
        }
    }


}
