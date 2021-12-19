using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Clone
{
    public class Board
    {
        int[,] BoardValues = new int[4,4];
        public Board()
        {
            
        }
        public void RenderBoard()
        {
            Console.WriteLine("Rendering the Board");
            
            for(int row = 0; row < 4; row++)
            {
                for(int col = 0; col < 4; col++)
                {
                    Console.Write(BoardValues[row, col]);
                }
                Console.Write("\n");
            }
        }
    }
}
