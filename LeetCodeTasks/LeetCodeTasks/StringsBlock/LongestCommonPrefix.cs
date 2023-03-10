using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.StringsBlock
{
    public class LongestCommonPrefix
    {
        public static string LongestCommonPrefixMethod(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix.Length == 0)
                    {
                        return "";
                    }
                }
            }
            return prefix;
        }
    }
}
