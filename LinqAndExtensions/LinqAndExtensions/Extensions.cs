using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndExtensions
{
    public static class StudentExtension
    {
        public static bool IsAbleToVote(this Person person)
        {
            return person.Age >= 18;
        }
        public static string FullIdentity(this Person person)
        {
            return $"{person.FirstName} {person.LastName}";
        }
    }

    public static class IntegerExtension
    {
        public static int SecondPowerRaise(this int number)
        {
            return number * number;
        }
    }

    public static class StringExtension
    {
        public static string OneLowCaseOneUpperCase(this string word)
        {
            string result="";
            int i = 0;
            foreach (char c in word)
            {
                if (i % 2 == 0) result += char.ToUpper(c);
                else result += char.ToLower(c);

                i++;
            }
            return result;
        }
    }


}
