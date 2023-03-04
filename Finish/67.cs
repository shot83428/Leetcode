public class Solution {
    public string AddBinary(string a, string b)
    {
        bool flag = false;
        string result = string.Empty;
        if (b.Length > a.Length)
        {
            (b, a) = (a, b);
        }
        int index = 1;
        while (b.Length - index >= 0)
        {
            if (a[a.Length - index] == '1' && b[b.Length - index] == '1')
            {
                if (flag)
                {
                    result = '1' + result;
                }
                else
                {
                    result = '0' + result;
                }
                flag = true;
            }
            else if (a[a.Length - index] == '1' || b[b.Length - index] == '1')
            {
                if (flag)
                {
                    result = '0' + result;
                    flag = true;
                }
                else
                {
                    result = '1' + result;
                    flag = false;
                }
            }
            else
            {
                if (flag)
                {
                    result = '1' + result;
                }
                else
                {
                    result = '0' + result;
                }
                flag = false;
            }
            index++;
        }
        while (a.Length - index >= 0)
        {
            if (a[a.Length - index] == '1')
            {
                if (flag)
                {
                    result = '0' + result;
                    flag = true;
                }
                else
                {
                    result = '1' + result;
                    flag = false;
                }
            }
            else
            {
                if (flag)
                {
                    result = '1' + result;
                }
                else
                {
                    result = '0' + result;
                }
                flag = false;
            }
            index++;
        }
        if (flag)
        {
            result = '1' + result;
        }
        return result;
    }
}