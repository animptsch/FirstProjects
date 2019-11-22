using System;
using System.Collections.Generic;
using System.Text;

namespace Wumpus.Spielfiguren
{
    public class Raptor : Figur, ITier
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

        internal void Angreifen(Spieler spieler)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "ein Raptor";
        }
    }
}
