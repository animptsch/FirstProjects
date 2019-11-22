using System;
using Wumpus.Unterobjekte;

namespace Wumpus
{
    class Program
    {
        private static Hoehle hoehle;

        static void Main(string[] args)
        {
            hoehle = new Hoehle();

            foreach (var item in hoehle.Figuren)
            {
                Console.WriteLine("{0}, X={1}, Y={2}",
                    item, item.Position.X, item.Position.Y);
            }

            while (true)
            {
                NaechsteRunde();
            }           
        }

        private static void NaechsteRunde()
        {
            Console.WriteLine("Sie befinden an Position {0}", hoehle.Spieler.Position);

            Console.Write("An diesem Ort befindet sich ");

            bool andereFigur = false;
            foreach (var figur in hoehle.Figuren)
            {
                if (figur == hoehle.Spieler)
                {
                    continue;
                }
                else
                {
                    if (hoehle.Spieler.Position.Equals(figur.Position))
                    {
                        Console.WriteLine(figur);
                        andereFigur = true;
                    }
                }
            }

            if (!andereFigur)
            {
                Console.WriteLine("nichts.");
            }

            var key = Console.ReadKey();

            himmelsrichtungen richtung = himmelsrichtungen.sueden;

            switch (key.KeyChar)
            {
                case 'w':
                    richtung = himmelsrichtungen.norden;
                    break;

                case 's':
                    richtung = himmelsrichtungen.osten;
                    break;

                case 'a':
                    richtung = himmelsrichtungen.westen;
                    break;

                case 'y':
                    richtung = himmelsrichtungen.sueden;
                    break;

                default:
                    Console.WriteLine("Unbekanter Befehl");
                    break;
                
            }

            hoehle.Spieler.Gehen(richtung);


        }
    }
}
