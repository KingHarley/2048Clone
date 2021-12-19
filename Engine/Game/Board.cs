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
        Field[,] Fields = new Field[SIZE,SIZE];
        List<(int row, int col)> BoardIndices = new List<(int row, int col)>();

        public Board()
        {
            for (int row = 0; row < SIZE; row++)
            {
                for (int col = 0; col < SIZE; col++)
                {
                    BoardIndices.Add((row, col));
                    Fields[row, col] = new Field(0);
                    if (col > 0)
                    {
                        Fields[row, col].Left = Fields[row, col - 1];
                        Fields[row, col - 1].Right = Fields[row, col];
                    }
                    if (row > 0)
                    {
                        Fields[row, col].Up = Fields[row - 1, col];
                        Fields[row - 1, col].Down = Fields[row, col];
                    }
                } 
            }
        }

        private List<(int row, int col)> GetOpenFields()
        {
            var val = BoardIndices.Where(x => Fields[x.row, x.col].Value == 0).ToList();
            return val;
        }

        public bool IsOpenField()
        {
            return GetOpenFields().Any();
        }

        public void MakeMove(string input)
        {
            switch (input)
            {
                case "up":
                    for(int col = 0; col < SIZE; col++)
                        Fields[SIZE - 1, col].Move(input);
                    break;
                case "down":
                    for (int col = 0; col < SIZE; col++)
                        Fields[0, col].Move(input);
                    break;
                case "left":
                    for (int row = 0; row < SIZE; row++)
                        Fields[row, SIZE-1].Move(input);
                    break;
                case "right":
                    for (int row = 0; row < SIZE; row++)
                        Fields[row, 0].Move(input);
                    break;
            }

        }

        public void SpawnField()
        {
            var open_fields = GetOpenFields();

            var rnd = new Random();
            var field = open_fields[rnd.Next(open_fields.Count())];

            Fields[field.row, field.col].Value = 2;
        }
        public void RenderBoard()
        {
            Console.WriteLine("Rendering the Board");
            
            for(int row = 0; row < SIZE; row++)
            {
                for(int col = 0; col < SIZE; col++)
                {
                    Console.Write(Fields[row, col].Value);
                }
                Console.Write("\n");
            }
        }
    }
}
