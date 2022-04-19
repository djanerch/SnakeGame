using SimpleSnake.Utilities;
using SimpleSnakeGame.GameObjects;
using System;

namespace SimpleSnakeGame
{
    class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            Wall wall = new Wall(100, 40);
            Snake snake = new Snake(wall);

            Engine engine = new Engine(snake, wall);
            engine.Run();
        }
    }
}
