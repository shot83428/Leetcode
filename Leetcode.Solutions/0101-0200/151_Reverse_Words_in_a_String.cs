namespace Leetcode.Solutions
{
    public class Solution_151
    {
        public string ReverseWords(string s)
        {
            var words = s.Split(' ').ToList();
            words.RemoveAll(x => string.IsNullOrEmpty(x));
            words.Reverse();
            return String.Join(" ", words);
        }
    }
}
