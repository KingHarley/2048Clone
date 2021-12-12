using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Clone.Engine.Game
{
    public class Board
    {
        int[] boardValues = new int[16];
        public Board()
        {
            
        }

        public void Start()
        {
            RenderBoard();
        }

        public void RenderBoard()
        {
            Console.WriteLine("Rendering the Board");
        }
    }
}
