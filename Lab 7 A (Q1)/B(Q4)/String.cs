using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Q4_
{
    class String
    {
        public static string ReverseString(string a)
        {
            char[] chars = a.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);

        }

        public static string UpperCase(string a)
        {
            return a.ToUpper();
        }

        public static int CountChar(string a)
        {
            return a.Length;
        }

    }
}
