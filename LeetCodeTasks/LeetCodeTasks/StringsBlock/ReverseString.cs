using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.StringsBlock
{
    public class ReverseString
    {
        public ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;

            while(i < j)
            {
                char tempChar = s[i];
                s[i] = s[j];
                s[j] = tempChar;
                i++;
                j--;
            }
        }
    }
}
