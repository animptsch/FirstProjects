using System;
using System.Collections.Generic;
using System.Text;
using Wumpus.Unterobjekte;

namespace Wumpus.Spielfiguren
{
    public abstract class Figur 
    {
        public Unterobjekte.Position Position { get; set; }

        public int Geschwindigkeit { get; set; }

        public int Ausdauer { get; set; }

        public int Leben { get; set; }

        public Figur()
        {
            Position = new Position();
        }


        public abstract void Sterben();

        public void Gehen(himmelsrichtungen himmelsrichtung)
        {
            switch (himmelsrichtung)
            {
                case himmelsrichtungen.norden:
                    if (Position.Y > 0)
                    {
                        Position.Y--;
                    }
                    break;
                case himmelsrichtungen.osten:
                    if (Position.X < Hoehle.Laenge)
                    {
                        Position.X++;
                    }
                    break;
                case himmelsrichtungen.sueden:
                    if (Position.Y < Hoehle.Breite)
                    {
                        Position.Y++;
                    }
                    break;
                case himmelsrichtungen.westen:
                    if (Position.X > 0)
                    {
                        Position.X--;
                    }
                    break;
                default:
                    break;
            }
        }
        
    }
}
