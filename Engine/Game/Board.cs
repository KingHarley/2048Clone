using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Clone.Engine.Game
{
    public class Board
    {
        int[,] boardValues = new int[4,4];
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
            
            for(int row = 0; row < 4; row++)
            {
                for(int col = 0; col < 4; col++)
                {
                    Console.Write(boardValues[row, col]);
                }
                Console.Write("\n");
            }
        }
    }
}
