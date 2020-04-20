using System;
using System.Collections.Generic;
using System.Text;

namespace Naughts_And_Crosses
{
    class Board
    {

        protected Square[,] sqaures = new Square[3,3];

        public void GenerateBoard()
        {   
            for (int i = 0; i < sqaures.GetLength(0); i++)
            {
                for (int a = 0; a < sqaures.GetLength(1); a++)
                {
                    sqaures[i, a] = new Square();
                }
            }
        }

        public void DisplayBoard()
        {
            Console.WriteLine("   ¦   ¦   ");
            Console.WriteLine(" {0} ¦ {1} ¦ {2} ", sqaures[0,0].ReturnState(),sqaures[0,1].ReturnState(),sqaures[0,2].ReturnState());
            Console.WriteLine("___¦___¦___");
            Console.WriteLine("   ¦   ¦   ");
            Console.WriteLine(" {0} ¦ {1} ¦ {2} ", sqaures[1,0].ReturnState(), sqaures[1,1].ReturnState(), sqaures[1,2].ReturnState());
            Console.WriteLine("___¦___¦___");
            Console.WriteLine("   ¦   ¦   ");
            Console.WriteLine(" {0} ¦ {1} ¦ {2} ", sqaures[2,0].ReturnState(), sqaures[2,1].ReturnState(), sqaures[2,2].ReturnState());
            Console.WriteLine("   ¦   ¦   ");
            Console.WriteLine();
        }

        public bool UpdateBoard(int sqCoord, int piece)
        {
            if (sqCoord <= 9 && sqCoord >= 1)
            {
                sqCoord -= 1;
                int indexOne;
                int indexTwo;
                
                if (sqCoord < 3)
                {
                    indexOne = 0;
                    indexTwo = sqCoord;
                }
                else if(sqCoord < 6 && sqCoord > 2)
                {
                    indexOne = 1;
                    indexTwo = sqCoord - 3;
                }
                else
                {
                    indexOne = 2;
                    indexTwo = sqCoord - 6;
                }

                if (sqaures[indexOne,indexTwo].State == 0 )
                {
                    sqaures[indexOne,indexTwo].State = piece;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}