using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_22
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var strs = new List<string>();

            void Ge(int open, int close, string str)
            {
                if (open == 0 && close == 0)
                {
                    strs.Add(str);
                }
                if (open > 0)
                {
                    var newStr = str + "(";
                    Ge(open - 1, close, newStr);
                }
                if (open >= 0 && open < close)
                {
                    var newStr = str + ")";
                    Ge(open, close - 1, newStr);
                }
            }

            Ge(n, n, "");
            return strs;
        }

    }
}
