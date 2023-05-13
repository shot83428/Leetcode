using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_017
    {

        private static readonly string[] Cellphone = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }
            var digit = digits[0] - '0';
            var firstLetters = Cellphone[digit].Select(c => c.ToString());
            var restLetters = LetterCombinations(digits.Substring(1));
            return recMerge(firstLetters, restLetters);
        }

        private IList<string> recMerge(IEnumerable<string> strs1, IEnumerable<string> strs2)
        {
            if (strs2 == null || !strs2.Any())
            {
                return strs1.ToList();
            }
            var strs = new List<string>();
            foreach (var str1 in strs1)
            {
                foreach (var str2 in strs2)
                {
                    strs.Add(str1 + str2);
                }
            }
            return strs;
        }

    }
}
