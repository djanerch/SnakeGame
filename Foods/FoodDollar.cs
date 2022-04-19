using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnakeGame.GameObjects
{
    public class FoodDollar : Food
    {
        private const int points = 2;
        private const char foodSymbol = '$';
        public FoodDollar(Wall wall)
            : base(wall, foodSymbol, points)
        {
        }
    }
}
