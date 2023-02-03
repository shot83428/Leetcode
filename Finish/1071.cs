public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if(str1.Length<str2.Length){
            return GcdOfStrings(str2,str1);
        }
        if(str1.IndexOf(str2)==0){
            if(str1==str2){
                return str1;
            }
            return GcdOfStrings(str2,str1.Substring(str2.Length));
        }
        return string.Empty;
    }
}