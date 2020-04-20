using System;

namespace Naughts_And_Crosses
{
    class Program
    {
        static void Main(string[] args)
        {
            Board bd = new Board();
            bd.GenerateBoard();
            bd.DisplayBoard();
            bd.UpdateBoard(5, 2);
            bd.UpdateBoard(5, 1);
            bd.DisplayBoard();
        }
    }
}
