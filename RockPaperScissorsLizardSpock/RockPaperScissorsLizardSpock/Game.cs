using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        static int PlayerWinCount;
        static int PlayerTwoWinCount;
        static int AIWinCount;

        public Game()
        {

        }
        public void PlayGameOnePlayer()
        {

            Human HumanPlayer = new Human();
            AI AIPlayer = new AI();
            while (PlayerWinCount < 2 || AIWinCount < 2)
            {
                int playerOneChoice = HumanPlayer.UseWeapon();
                int playerAIChoice = AIPlayer.UseWeapon();
                int d;
                d = (5 + playerOneChoice - playerAIChoice) % 5;
                if (d == 1 || d == 3)
                {
                    Console.WriteLine("Player One Wins");
                    PlayerWinCount += 1;
                }
                else if (d == 2 || d == 4)
                {
                    Console.WriteLine("Player AI Wins");
                    AIWinCount += 1;
                }
                else if (d == 0)
                {
                    Console.WriteLine("tie");
                }

                if (PlayerWinCount == 2)
                {
                    Console.WriteLine("Player One wins best 2 out of 3 games!");
                }
                else if (AIWinCount == 2)
                {
                    Console.WriteLine("The Computer Won best 2 out of 3 games, better luck next time");
                }
            }
        }
                /////////////////////////////////////
                public void PlayGameTwoPlayers()
                {
                  //  Rules start = new Rules();
                  
                    Human HumanPlayerOne = new Human();
                    Human HumanPlayerTwo = new Human();
                    while (PlayerWinCount < 2 || PlayerTwoWinCount < 2)
                    {
                        int playerOneChoice = HumanPlayerOne.UseWeapon();
                        int playerTwoChoice = HumanPlayerTwo.UseWeapon();
                        int c;
                        c = (5 + playerOneChoice - playerTwoChoice) % 5;
                        if (c == 1 || c == 3)
                        {
                            Console.WriteLine("Player One Wins");
                            PlayerWinCount += 1;
                        }
                        else if (c == 2 || c == 4)
                        {
                            Console.WriteLine("Player Two Wins");
                            PlayerTwoWinCount += 1;
                        }
                        else if (c == 0)
                        {
                            Console.WriteLine("tie");
                        }

                        if (PlayerWinCount == 2)
                        {
                            Console.WriteLine("Player One wins best 2 out of 3 games!");
                        }
                        else if (PlayerTwoWinCount == 2)
                        {
                            Console.WriteLine("Player Two wins best 2 out of 3 games!");
                        }
                    }
                }
            
        
    }
}
