using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo_FizzBuzz
{
    public static class FooBarQix2
    {
        public static string Of(int i)
        {
            string ret = "";
            if (i % 3 == 0) { ret += "Foo"; }
            if (i % 5 == 0) { ret += "Bar"; }
            if (i % 7 == 0) { ret += "Qix"; }
            foreach (char c in i.ToString())
            {
                if (c == '3') { ret += "Foo"; }
                if (c == '5') { ret += "Bar"; }
                if (c == '7') { ret += "Qix"; }
            }
            if (ret == "") { ret = i.ToString(); }
            return ret;
        }
    }
}
