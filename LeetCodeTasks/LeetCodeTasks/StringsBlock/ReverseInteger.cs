using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.StringsBlock
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            char[] s = x.ToString().ToCharArray();

            int i = s[0] == '-' ? 1 : 0;
            int j = s.Length - 1;

            while (i < j)
            {
                char tempChar = s[i];
                s[i] = s[j];
                s[j] = tempChar;
                i++;
                j--;
            }

            try
            {
                return int.Parse(s);
            }
            catch
            {
                return 0;
            }
        }
        
    }
}
