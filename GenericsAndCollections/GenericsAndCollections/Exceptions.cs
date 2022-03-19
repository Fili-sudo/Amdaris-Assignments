using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections
{
    public class InvalidColorException : Exception
    {
        public InvalidColorException()
        {

        }

        public InvalidColorException(string message) : base(message)
        {

        }

        public InvalidColorException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
