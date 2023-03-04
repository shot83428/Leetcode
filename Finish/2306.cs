public class Solution
{
    public long DistinctNames(string[] ideas)
    {
        HashSet<string>[] dic = new HashSet<string>[26];

        for (int index = 0; index < 26; index++)
        {
            dic[index] = new HashSet<string>();
        }
        for (int index = 0; index < ideas.Length; index++)
        {
            dic[ideas[index][0] - 'a'].Add(ideas[index][1..]);
        }
        long result = 0;

        for (int index = 0; index < 25; index++)
        {
            for (int j = index + 1; j < 26; j++)
            {
                long numOfMutual = 0;
                foreach (string ideaA in dic[index])
                {
                    if (dic[j].Contains(ideaA))
                    {
                        numOfMutual++;
                    }
                }
                result += 2 * (dic[index].Count - numOfMutual) * (dic[j].Count - numOfMutual);
            }
        }


        return result;
    }
}