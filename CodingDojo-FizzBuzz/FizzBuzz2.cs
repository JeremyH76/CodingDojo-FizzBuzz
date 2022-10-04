using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo_FizzBuzz
{
    public static class FizzBuzz2
    {
        public static string Next(int i)
        {
            return Of(i + 1);
        }

        public static string Of(int i)
        {
            string ret = "";
            if (i % 3 == 0) { ret += "Fizz"; }
            if (i % 5 == 0) { ret += "Buzz"; }
            if (ret == "") { ret = i.ToString(); }
            return ret;
        }
    }
}
