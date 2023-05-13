using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_10
    {
        public bool IsMatch(string s, string p)
        {
            var pattern = new Regex("^" + p + "$");

            return (pattern.IsMatch(s));
        }
    }
}
