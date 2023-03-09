using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.StringsBlock
{
    public class FirstUniqueCharacter
    {
        public static int FirstUniqChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if(i != j)
                    {
                        if (s[i] == s[j])
                            break;                       
                    }

                    if (j == s.Length - 1)
                        return i;

                }
            }
            return -1;
        }
    }
}
