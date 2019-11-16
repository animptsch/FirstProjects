using System;
using System.Collections.Generic;
using System.Text;

namespace Wumpus.Spielfiguren
{
    public class Wumpus : Figur, ITier
    {
        public int Reaktionsszeit { get; set; }

        public void Fluechten()
        {
            throw new NotImplementedException();
        }

        public override void Sterben()
        {
            throw new NotImplementedException();
        }
    }
}
