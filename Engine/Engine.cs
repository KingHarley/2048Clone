using _2048Clone.Engine.Game;
using System;

namespace _2048Clone.Engine
{
    public class Engine
    {
        public Game.Game theGame;

        public Engine()
        {
            theGame = new Game.Game();
        }

        public void Start()
        {
            theGame.Start();
        }
    }
}
