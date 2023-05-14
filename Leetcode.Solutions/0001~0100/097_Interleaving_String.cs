namespace Leetcode.Solutions
{
    public class Solution_097
    {
        private readonly HashSet<(int, int)> set = new HashSet<(int, int)>();
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
                return false;

            if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2) && string.IsNullOrEmpty(s3))
                return true;

            bool res = false;
            if (!string.IsNullOrEmpty(s1) && s1[0] == s3[0])
            {
                var len = DPLen(s1, s3);
                while (len > 0 && !res)
                {
                    if (!set.Contains((s1.Length - len, s2.Length)))
                    {
                        res = res | IsInterleave(s1.Substring(len), s2, s3.Substring(len));
                        set.Add((s1.Length - len, s2.Length));
                    }
                    else
                        break;
                    len--;
                }
            }
            if (!string.IsNullOrEmpty(s2) && s2[0] == s3[0])
            {
                var len = DPLen(s2, s3);
                while (len > 0 && !res)
                {
                    if (!set.Contains((s1.Length, s2.Length - len)))
                    {
                        res = res | IsInterleave(s1, s2.Substring(len), s3.Substring(len));
                        set.Add((s1.Length, s2.Length - len));
                    }
                    else
                        break;
                    len--;
                }
            }
            return res;
        }
        public int DPLen(string s1, string s2)
        {
            int len = 0;
            for (int index = 0; index < s1.Length; index++)
            {
                if (s1[index] == s2[index])
                {
                    len++;
                }
                else
                {
                    break;
                }
            }
            return len;
        }
    }
}
