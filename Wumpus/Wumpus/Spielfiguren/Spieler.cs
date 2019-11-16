using System;
using System.Collections.Generic;
using System.Text;

namespace Wumpus.Spielfiguren
{
    public class Spieler : Figur
    {
        
        public int Schuss { get; set; }


        public void schiessen(int reaktionszeitSpieler, Figur figur)
        {
            if (Schuss<=0)
            {
                Console.WriteLine("Ohne Munition kannst du nicht schiessen");
                return;
            }
            Schuss--;


            if (figur is ITier tier)
            {
                if (reaktionszeitSpieler < tier.Reaktionsszeit)
                {
                    figur.Leben--;

                    if (figur.Leben > 0)
                    {
                        figur.Sterben();
                    }
                    else
                    {
                        tier.Fluechten();
                    }
                }
                else
                {
                    if (figur is Raptor raptor)
                    {
                        raptor.Angreifen(this);
                    }

                    if (figur is Riesenfledermaus riesenfledermaus)
                    {
                        riesenfledermaus.Teleportieren(this);
                    }

                    if (figur is Wumpus wumpus)
                    {
                        wumpus.Fluechten();
                    }
                }
            }
        }


        public override void Sterben()
        {
            throw new NotImplementedException();
        }

    }
}
