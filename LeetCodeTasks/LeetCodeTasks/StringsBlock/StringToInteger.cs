using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.StringsBlock
{
    public class StringToInteger
    {
        public static int MyAtoi(string s)
        {
            //var resultString = new String(s.Where(c => Char.IsNumber(c) || c=='-' || c== '+').ToArray());
            var resultString = new StringBuilder();
            bool goNumb = false;
            bool goZnak = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '-' || s[i] == '+')
                {
                    if (goNumb)
                        break;
                    else if (goZnak)
                        return 0;
                    else
                        resultString = new StringBuilder().Append(s[i]);
                    goZnak = true;
                }

                else if (Char.IsNumber(s[i]))
                {
                    goNumb = true;
                    resultString.Append(s[i]);
                }

                else if (!goNumb && s[i] != ' ')
                {
                    return 0;
                }
                else if (goNumb)
                    break;

                /*else
                    return 0;*/
            }

            try
            {
                return int.Parse(resultString.ToString());
            }
            catch
            {
                if (resultString[0] == '-')
                    return Int32.MinValue;
                else
                    return Int32.MaxValue;
            }            
        }
    }
}
