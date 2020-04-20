using System;
using System.Collections.Generic;
using System.Text;

namespace Naughts_And_Crosses
{
    class Board
    {

        protected Sqaure[] sqaures = new Sqaure[9];

        public Sqaure[] GenerateBoard()
        {   
            for (int i = 0; i < sqaures.Length; i++)
            {
                sqaures[i] = new Sqaure();
            }
            return sqaures;
        }

        public void DisplayBoard()
        {
            Console.WriteLine("   ¦   ¦   ");
            Console.WriteLine(" {0}  ¦ {1}  ¦ {2} ", sqaures[0].ToString(),sqaures[1].ToString(),sqaures[2].ToString());
            Console.WriteLine("___¦___¦___");
        }
    }
}