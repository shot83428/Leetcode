namespace Leetcode.Solutions
{
    public class Solution_071
    {
        public string SimplifyPath(string path)
        {
            var folders = path.Split('/').ToList();
            string result = string.Empty;
            for (int index = 0; index < folders.Count; index++)
            {
                if (string.IsNullOrEmpty(folders[index]) || string.Equals(folders[index], "."))
                {
                    folders.RemoveAt(index);
                    index--;
                    continue;
                }
                if (string.Equals(folders[index], ".."))
                {
                    folders.RemoveAt(index);
                    if (index != 0)
                    {
                        folders.RemoveAt(index - 1);
                        index--;
                    }
                    index--;
                    continue;
                }
            }
            foreach (var str in folders)
            {
                result = result + "/" + str;
            }
            if (string.IsNullOrEmpty(result))
            {
                return "/";
            }
            return result;
        }
    }
}
