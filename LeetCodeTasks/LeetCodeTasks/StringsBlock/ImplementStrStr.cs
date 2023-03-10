using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.StringsBlock
{
    public class ImplementStrStr
    {
        public static int StrStr(string haystack, string needle)
        {
            if(haystack.Length < needle.Length)
                return -1;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0] && haystack.Length-i >= needle.Length)
                {
                    for (int j = i, m=0; m < needle.Length; j++,m++)
                    {
                        if (haystack[j] != needle[m])
                            break;
                        if (m == needle.Length - 1)
                            return i;
                    }
                }
            }

            return -1;
        }
    }
}
