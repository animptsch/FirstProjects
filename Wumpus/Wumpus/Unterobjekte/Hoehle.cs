using System;
using System.Collections.Generic;
using Wumpus.Spielfiguren;

namespace Wumpus.Unterobjekte
{
    public class Hoehle
    {
        public const int Breite = 4;
        public const int Laenge = 10;

        public const int RaptorenAnzahl = 10;
        public const int FledermausAnzahl = 5;

        public Raptor[] Raptoren { get; set; }
        public Riesenfledermaus[] Riesenfledermaeuse { get; set; }
        public List<Figur> Figuren { get; set; }
        public Wumpus.Spielfiguren.Wumpus WumpusFigur { get; set; }
        public Spieler Spieler { get; set; }

        public readonly Position Eingang;

        public Hoehle()
        {
            //Figuren definieren 
            Spieler = new Spieler();
            
            Raptoren = new Raptor[RaptorenAnzahl];
            for (int i = 0; i < RaptorenAnzahl; i++)
            {
                Raptoren[i] = new Raptor();
            }

            Riesenfledermaeuse = new Riesenfledermaus[FledermausAnzahl];
            for (int i = 0; i < FledermausAnzahl; i++)
            {
                Riesenfledermaeuse[i] = new Riesenfledermaus();

            }

            WumpusFigur = new Spielfiguren.Wumpus();

            //Alle Figuren der Liste Figuren hinzufügen
            Figuren = new List<Figur>()
            {
                WumpusFigur,
                Spieler                
            };

            Figuren.AddRange(Raptoren);
            Figuren.AddRange(Riesenfledermaeuse);

            //
            Eingang = new Position()
            {
                X = 10, 
                Y = 5
            };            

            //Für jede einzelne Figur soll die Position bestimmt werden
            foreach (var figur in Figuren)
            {
                if (figur is Spieler)
                {
                    figur.Position = Eingang;
                }
                else
                {
                    figur.Position.SetStartPosition(Laenge,Breite);
                }
            }
        }

    }
}
