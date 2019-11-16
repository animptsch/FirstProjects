using System;
using System.Collections.Generic;
using System.Text;

namespace Wumpus.Spielfiguren
{
    public interface ITier 
    {
        public int Reaktionsszeit { get; set; }

        public void Fluechten();
    }
}
