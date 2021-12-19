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

        private void Play()
        {
            while(IsPlaying)
            {
                //Check for user input from the player.
                //Make the player's move
                //Spawn another 2 on the board
                //Check if the game is over (i.e. No available spaces)
                //Calculate the total score on the board
            }
        }
    }
}
