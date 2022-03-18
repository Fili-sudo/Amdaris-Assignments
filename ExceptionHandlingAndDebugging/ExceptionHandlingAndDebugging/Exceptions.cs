using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAndDebugging
{
    public class Out : Exception
    {
        public override string ToString()
        {
            return "Out";
        }
    }

    public class Gol : Exception
    {
        public override string ToString()
        {
            return "Gol";
        }
    }

    public class Corner : Exception
    {
        public override string ToString()
        {
            return "Corner";
        }
    }
}
