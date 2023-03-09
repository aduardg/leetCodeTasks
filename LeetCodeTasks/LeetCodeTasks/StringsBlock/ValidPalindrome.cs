using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.StringsBlock
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            var onlyLetters = new String(s.Where(c => Char.IsNumber(c) || Char.IsLetter(c)).ToArray()).ToLower();

            if (onlyLetters.Length == 0)
                return true;

            int end = onlyLetters.Length - 1;
            int start = 0;

            while(start < end)
            {
                if (onlyLetters[start] != onlyLetters[end])
                    return false;
                start++;
                end--;

            }


            return true;
        }
    }
}
