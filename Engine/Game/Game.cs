using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Clone
{
    public class Game
    {
        public Board TheBoard { get; set; }
        private bool IsPlaying;
        public Game()
        {
            Console.WriteLine("This is the constructor of the Game");
            TheBoard = new Board();
            IsPlaying = true;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to a clone of 2048.\n");
            //Add two random 2's to the board
            this.Play();
        }

        private bool IsValidInput(string input)
        {
            if (string.Equals(input, "down") || string.Equals(input, "up") || string.Equals(input, "left") || string.Equals(input, "right"))
                return true;
            return false;
        }

        private void Play()
        {
            TheBoard.RenderBoard();
            while(IsPlaying)
            {
                //Check for user input from the player.
                var input = Console.ReadLine().ToLower();
                while(!IsValidInput(input))
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Valid Inputs: down, up, left, right");
                    input = Console.ReadLine().ToLower();
                }

                TheBoard.MakeMove(input);
                TheBoard.SpawnField();
                TheBoard.RenderBoard();
                IsPlaying = TheBoard.IsOpenField();
                //Check if the game is over (i.e. No available spaces)
                //Calculate the total score on the board
            }
        }
    }
}
