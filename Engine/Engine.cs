using System;

namespace _2048Clone
{
    public class Engine
    {
        public Game myGame;

        public Engine()
        {
            myGame = new Game();
        }

        public void Start()
        {
            myGame.Start();
        }
    }
}
