using System;
using System.Collections.Generic;
using System.Text;

namespace Naughts_And_Crosses
{
    class Square
    {
        public int State { get; set; } = 0;
        enum StatesOfSquare {_, X, O }

        public override string ToString()
        {
            return "State = " + (StatesOfSquare)State;
        }
        public string ReturnState()
        {
            return Convert.ToString((StatesOfSquare)State);
        }
    }

}
