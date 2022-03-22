using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndExtensions
{
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ocupation { get; set; }
        public bool Married { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, age={Age}, Married:{Married}, Ocupation:{Ocupation}";
        }

    }
}
