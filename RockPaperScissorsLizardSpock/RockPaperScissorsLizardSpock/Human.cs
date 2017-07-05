using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {

        public Human()
        {

        }



        public int UseWeapon()
        {
            Console.WriteLine("Please choose your weapon: rock, paper, scissors, spock, lizard");
            string UserInput = Console.ReadLine();
            int number = weapons.IndexOf(UserInput);
            return number;
        }   
        
            
        
        

        

    }
}
        
        
            