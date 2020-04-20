using System;
using System.Collections.Generic;
using System.Text;

namespace Naughts_And_Crosses
{
    class Player
    {
        public string name { get; set; }
        public char Piece { get; set; }

        public Player(string pName, char piece)
        {
            name = pName;
            Piece = piece;
        }
    }
}
