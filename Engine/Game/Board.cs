using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Clone
{
    public class Board
    {
        const int SIZE = 4;
        int[,] BoardValues = new int[SIZE,SIZE];
        List<(int row, int col)> BoardIndices = new List<(int row, int col)>();

        public Board()
        {
            for(int row = 0; row < SIZE; row++)
            {
                for(int col = 0; col < SIZE; col++)
                {
                    BoardIndices.Add((row, col));
                }
            }
        }

        private List<(int row, int col)> GetOpenFields()
        {
            var val = BoardIndices.Where(x => BoardValues[x.row, x.col] == 0).ToList();
            return val;
        }

        public bool IsOpenField()
        {
            return GetOpenFields().Any();
        }

        public void MakeMove(string input)
        {
            
        }

        public void SpawnField()
        {
            var open_fields = GetOpenFields();

            var rnd = new Random();
            var field = open_fields[rnd.Next(open_fields.Count())];

            BoardValues[field.row, field.col] = 2;
        }
        public void RenderBoard()
        {
            Console.WriteLine("Rendering the Board");
            
            for(int row = 0; row < SIZE; row++)
            {
                for(int col = 0; col < SIZE; col++)
                {
                    Console.Write(BoardValues[row, col]);
                }
                Console.Write("\n");
            }
        }
    }
}
