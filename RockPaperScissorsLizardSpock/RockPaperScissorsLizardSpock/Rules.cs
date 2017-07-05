using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Rules
    {


        public Rules()
        {


        }
        public void DisplayRules()
        {
            Console.WriteLine("Rules for Rock, Paper, Scissors, Lizard, Spock:\n" +
                "Scissors cuts Paper\n" +
                "Paper covers Rock\n" +
                "Rock crushes Lizard\n" +
                "Lizard poisons Spock\n" +
                "Spock smashes Scissors\n" +
                "Scissors decapitates Lizard\n" +
                "Lizard eats Paper\n" +
                "Paper disproves Spock\n" +
                "Spock vaporizes Rock\n" +
                "(and as it always has) Rock crushes Scissors.\n\n"+
                "You will play best two out of three rounds!\n\n" +
                "Press ENTER to Start the game.\n");
                
            Console.ReadKey();
            Rules ChoosePlayer = new Rules();
            ChoosePlayer.ChoosePlayers();
        }

        public void ChoosePlayers()
        {
            Console.WriteLine("Would you like to play (one) or (two) players?\n" +
                "Type (quit) to exit");
            string PickPlayer = Console.ReadLine();

            {
                if (PickPlayer == "one")
                {
                    Console.WriteLine("Ok, you will play against the computer.");
                    Game start = new Game();
                    start.PlayGameOnePlayer();
                }
                else if (PickPlayer == "two")
                {
                    Console.WriteLine("Ok, you will play against a friend.");
                    Game play = new Game();
                    play.PlayGameTwoPlayers();
                }
                else if (PickPlayer == "quit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please enter (one) or (two).");
                    ChoosePlayers();
                }
            
            }
        }

    }
}
   
         
                

              
