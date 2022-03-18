using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAndDebugging
{
    public class Minge
    {
        private int X, Y;

        public int XProperty 
        {
            get { return X; }
        }
        public int YProperty 
        {
            get { return Y; }
        }

        public Minge(int X, int Y)
        {
            this.X = X; 
            this.Y = Y;
        }
        public void suteaza()
        {
            CoordinateGenerator coordinateGenerator = new CoordinateGenerator();
            X = coordinateGenerator.generateX();
            Y = coordinateGenerator.generateY();

            if (Y == 0 || Y == 50) throw new Out();
            if (X == 0 || X == 100)
                if (Y >= 20 && Y <= 30) throw new Gol();
                else throw new Corner();
        }
    }
}
