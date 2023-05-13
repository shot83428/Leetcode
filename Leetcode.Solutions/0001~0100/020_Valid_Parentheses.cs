using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class Solution_020
    {
        public bool IsValid(string s)
        {
            Stack<char> stack_op = new Stack<char>();
            stack_op.Push('!');
            int count = 0, len = s.Length;
            if (len == 1) return false;
            while (count < len)
            {
                switch (s[count])
                {
                    case '}':
                        if (stack_op.Pop() != '{')
                            return false;
                        break;
                    case ')':
                        if (stack_op.Pop() != '(')
                            return false;
                        break;
                    case ']':
                        if (stack_op.Pop() != '[')
                            return false;
                        break;
                    case '{':
                    case '[':
                    case '(':
                        stack_op.Push(s[count]);
                        break;
                }
                count++;
            }
            if (stack_op.Peek() != '!')
                return false;
            return true;
        }
    }
}
