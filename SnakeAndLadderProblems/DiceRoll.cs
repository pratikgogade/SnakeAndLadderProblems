using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblems
{
    internal class DiceRoll
    {
        public void Diceroll()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("You get number " + dice);
        }
    }
}