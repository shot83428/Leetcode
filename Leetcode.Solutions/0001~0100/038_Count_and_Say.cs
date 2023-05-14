using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_038
    {
        public string CountAndSay(int n)
        {
            string str = "";
            return CountAndSayRec(n, str);
        }

        public string CountAndSayRec(int n, string str)
        {
            if (n == 0)
            {
                return str;
            }
            if (str == "")
            {
                return CountAndSayRec(n - 1, "1");
            }
            string newStr = "";
            char word = str[0];
            int count = 1;
            for (int index = 1; index < str.Length; index++)
            {
                if (str[index] == str[index - 1])
                {
                    count++;
                }
                else
                {
                    newStr = newStr + count.ToString() + word;
                    count = 1;
                    word = str[index];
                }
            }
            newStr = newStr + count.ToString() + word;
            return CountAndSayRec(n - 1, newStr);
        }
    }
}
