using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1LinqTask
{
    public static class palidrom
    {
        public static bool IsPalindrome(this string text)
        {
            if (text == null)
                return false;

            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                    return false;
            }

            return true;
        }
    }
}
