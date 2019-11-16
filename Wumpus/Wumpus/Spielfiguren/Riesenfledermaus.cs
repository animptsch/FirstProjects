using System;
using System.Collections.Generic;
using System.Text;

namespace Wumpus.Spielfiguren
{
    public class Riesenfledermaus : Figur, ITier
    {
        public int Reaktionsszeit { get; set; }

        public override void Sterben()
        {
            throw new NotImplementedException();
        }

        public void Fluechten()
        {
            throw new NotImplementedException();
        }

        internal void Teleportieren(Spieler spieler)
        {
            throw new NotImplementedException();
        }
    }
}
