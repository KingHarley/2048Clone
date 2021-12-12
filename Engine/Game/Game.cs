using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Clone.Engine.Game
{
    public class Game
    {
        public Board theBoard { get; set; }
        public Game()
        {
            Console.WriteLine("This is the constructor of the Game");
            theBoard = new Board();
        }

        public void Start()
        {
            theBoard.Start();
            Console.WriteLine("Yay we've started the Game");

        }
    }
}
