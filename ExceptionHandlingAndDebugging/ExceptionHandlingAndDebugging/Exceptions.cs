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

    public class InputException1 : Exception
    {
        public InputException1()
        {

        }

        public InputException1(string message) : base(message)
        {

        }

        public InputException1(string message, Exception innerException) : base(message, innerException)
        {

        }
    }

    public class InputException2 : Exception
    {
        public InputException2()
        {

        }

        public InputException2(string message) : base(message)
        {

        }

        public InputException2(string message, Exception innerException) : base(message, innerException)
        {

        }
    }


}
