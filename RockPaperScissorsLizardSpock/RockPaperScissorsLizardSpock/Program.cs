using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ROCK,PAPER,SCISSORS,LIZARD,SPOCK GAME!!");
            Rules start = new Rules();
            start.DisplayRules();

            Console.ReadKey();
        }
    }
}
