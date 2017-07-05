using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Player
    {
       
        public List<string> weapons;
        public Player()
        {
            weapons = new List<string>()
            {
                "rock",
                "paper",
                "scissors",
                "spock",
                "lizard"
            };

        }

        public void WeaponsList()
        {
            
            Human ChooseWeapon = new Human();
            ChooseWeapon.UseWeapon();
            
            
        }
      
    }
}