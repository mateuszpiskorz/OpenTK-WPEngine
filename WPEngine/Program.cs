using System;

namespace WPEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Game game = Game.Initialize(800, 600, 60.0, "OpenTKTest"))
            {
                game.Run();
            }
        }
    }
}
