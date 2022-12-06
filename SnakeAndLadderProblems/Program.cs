using System;
namespace SnakeAndLadderProblems
{
    public class Programs
    {
        static void Main(string[] args)
        {
            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("Welcome to Snake And Ladder Game");
                Console.WriteLine("1.Start " + "\n" + "2.Exit");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        StartGame startGame = new StartGame();
                        startGame.Game();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}