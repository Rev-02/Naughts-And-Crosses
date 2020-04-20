using System;
using System.ComponentModel;
using System.Reflection;
using System.Threading.Tasks.Dataflow;

namespace Naughts_And_Crosses
{
    class Program
    {
        static void Main(string[] args)
        {
            string replay = "0";
            Console.WriteLine("Naughts And Crosses");
            Console.WriteLine("Please enter name for Player 1: \n");
            string p1Name = Console.ReadLine();
            Console.WriteLine("Please enter name for Player 2: \n");
            string p2Name = Console.ReadLine();
            Player p1 = new Player(p1Name);
            Player p2 = new Player(p2Name);
            // init game
            do
            {
                int winner = 0;
                Board bd = new Board();
                bd.GenerateBoard();
                while (true)
                {
                    bd.DisplayBoard();
                    askMove(1, bd, p1.name);
                    bd.DisplayBoard();
                    winner = bd.CheckWinner();
                    if (winner != 0) { break; }
                    askMove(2, bd, p2.name);
                    winner = bd.CheckWinner();
                    if (winner != 0) { break; }
                }
                bd.DisplayBoard();
                switch (winner)
                {
                    case 1:
                        Console.WriteLine("Congratulations {0} you won!", p1.name);
                        break;
                    case 2:
                        Console.WriteLine("Congratulations {0} you won!", p2.name);
                        break;
                    case 4:
                        Console.WriteLine("Draw!");
                        break;
                }
                Console.WriteLine("Press 1 to replay, any other key to quit");
                replay = Console.ReadLine();
            } while (replay == "1");
            //Console.ReadLine();
        }
        public static void askMove(int player, Board bd, string pName)
        {
            Console.WriteLine("");
            Console.WriteLine("Player {0} Move (1-9)", pName);
            int pMove = 0;
            while (pMove == 0)
            {
                try
                {
                    pMove = Convert.ToInt32(Console.ReadLine());
                    if (bd.UpdateBoard(pMove,player) == false)
                    {
                        Console.WriteLine("Invalid Sqaure - Might be taken");
                        pMove = 0;
                        Console.WriteLine("Player {0} Move (0-9)", player);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Player {0} Move (0-9)", player);
                }
            }
        }
    }
}
