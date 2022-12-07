using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblems
{
    internal class CheckOptions
    {
        public void Check()
        {
            int position = 0;
            Random random = new Random();
            int die = random.Next(1, 7);
            Console.WriteLine("Die roll value " + die);
            int num = random.Next(1, 4);
            Console.WriteLine("Player Gets option " + num);
            switch (num)
            {
                case 1:
                    Console.WriteLine("Player Stays In The Same Position");
                    break;
                case 2:
                    position += die;
                    Console.WriteLine("Player Moves Ahead And Player Position Is " + position);
                    break;
                default:
                    position -= die;
                    Console.WriteLine("Player Moves Behind And Player Position Is " + position);
                    break;
            }
        }
    }
}