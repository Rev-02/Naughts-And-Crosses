using System;
using System.Collections.Generic;
using System.Text;

namespace Naughts_And_Crosses
{
    class Sqaure
    {
        public int State { get; set; } = 0;
        enum StatesOfSquare {_, X, O }

        public override string ToString()
        {
            return "State = " + (StatesOfSquare)State;
        }
        public string returnState()
        {
            return Convert.ToString((StatesOfSquare)State);
        }
    }
}
