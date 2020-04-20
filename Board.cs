using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naughts_And_Crosses
{
    class Board
    {

        protected Square[,] sqaures = new Square[3,3];
        private int movesMade = 0;

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
                    movesMade += 1;
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

        private int CheckWin(Square[] mySquares)
        {
            if ((mySquares[0].State == mySquares[1].State && mySquares[0].State == mySquares[2].State) && mySquares[0].State != 0)
            {
                return mySquares[0].State;
            }
            else
            {
                return 0;
            }
        }

        private int CheckColumn(int column)
        {
            Square[] columnArr = new Square[3];

            for (int i = 0; i < sqaures.GetLength(0); i++)
            {
                columnArr[i] = sqaures[i, column];
            }

            return CheckWin(columnArr);
        }

        private int CheckDiagonal(int side) //side == 0 : down and right diagonal, side == 1: down and left diagonal
        {
            Square[] columnArr = new Square[3];
            if (side == 0)
            {
                for (int i = 0; i < sqaures.GetLength(0); i++)
                {
                    for (int a = 0; a < sqaures.GetLength(1); a++)
                    {
                        if(a == i)
                        {
                            columnArr[i] = sqaures[i, a];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < sqaures.GetLength(0); i++)
                {
                    for (int a = 0; a < sqaures.GetLength(1); a++)
                    {
                        if(a+i == 2)
                        {
                            columnArr[i] = sqaures[i, a];
                        }
                    }
                }
            }

            return CheckWin(columnArr);
        }

        private int CheckRow(int row)
        {
            Square[] columnArr = new Square[3];
            for (int i = 0; i < sqaures.GetLength(0); i++)
            {
                columnArr[i] = sqaures[row,i];
            }

            return CheckWin(columnArr);
        }


        public int CheckWinner()
        {
            for (int i = 0; i < 2; i++)
            {
                if (CheckColumn(i) != 0)
                {
                    return CheckColumn(i);
                }
                else if(CheckRow(i) != 0)
                {
                    return CheckRow(i);
                }
            }
            if (CheckDiagonal(0) != 0)
            {
                return CheckDiagonal(0);
            }
            else if(CheckDiagonal(1) != 0)
            {
                return CheckDiagonal(1);
            }
            
            if (movesMade == 9)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
    }
}