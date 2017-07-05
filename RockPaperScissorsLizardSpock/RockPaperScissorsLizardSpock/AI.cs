using System;

namespace RockPaperScissorsLizardSpock
{
    class AI : Player
    {
        public AI()
        {

        }
        public int UseWeapon()
        {
            Random weapon = new Random();
            int number = weapon.Next(0, 5);
            
                if (number is 0)
                {
                    Console.WriteLine("computer used rock");
                }
                else if (number is 1)
                {
                    Console.WriteLine("computer used paper");
                }
                else if (number is 2)
                {
                    Console.WriteLine("computer used scissors");
                }
                else if (number is 3)
                {
                    Console.WriteLine("computer used spock");
                }
                else if (number is 4)
                {
                    Console.WriteLine("computer used lizard");
                }
                Human Score = new Human();
                return number;

            
        }    
    }
}
