using System;
using System.Collections.Generic;
using System.Text;

namespace Wumpus.Unterobjekte
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void SetStartPosition(int maxLaenge, int maxBreite)
        {
            var rand = new Random();

            X = rand.Next(0, maxLaenge);
            Y = rand.Next(0, maxBreite);
        }

        public override string ToString()
        {
            return String.Format("X={0}, Y={1}",X,Y);
        }


        public override bool Equals(object obj)
        {
            if (!(obj is Position position2))
            {
                return false;
            }

            bool result = 
                this.X == position2.X && 
                this.Y == position2.Y;

            return result;
        }

    }
}
