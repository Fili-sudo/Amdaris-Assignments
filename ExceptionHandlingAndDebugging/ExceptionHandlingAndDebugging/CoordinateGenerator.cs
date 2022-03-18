using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAndDebugging
{
    public class CoordinateGenerator
    {
        private Random randomGenerator;

        public CoordinateGenerator()
        {
            randomGenerator = new Random();
        }
        public int generateX()
        {
            int x = randomGenerator.Next(101);
            if (x < 5)
            {
                x = 0;
            }
            else if (x > 95)
            {
                x = 100;
            }
            else
            {
                x = randomGenerator.Next(99) + 1;
            }
            return x;
        }

        public int generateY()
        {
            int y = randomGenerator.Next(101);
            if (y < 5)
            {
                y = 0;
            }
            else if (y > 95)
            {
                y = 50;
            }
            else
            {
                y = randomGenerator.Next(49) + 1;
            }
            return y;
        }
    }
}
