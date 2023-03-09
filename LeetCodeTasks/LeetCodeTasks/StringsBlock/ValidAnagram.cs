using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.StringsBlock
{
    public class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            char[] charsS = s.ToCharArray();
            Array.Sort(charsS);

            char[] charsT = t.ToCharArray();
            Array.Sort(charsT);

            for (int i = 0; i < charsS.Length; i++)
            {
                if (charsS[i] != charsT[i])
                    return false;
            }

            return true;

        }
    }
}
