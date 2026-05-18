public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int len1 = word1.Length;
        int len2 = word2.Length;
        int i = 0;
        int j = 0;
        StringBuilder sb = new StringBuilder();
        while(i < len1 && j< len2){
            sb.Append(word1[i]);
            sb.Append(word2[j]);
            i++;j++;
        }
        while(i < len1){
            sb.Append(word1[i]);
            i++;
        }
        while(j < len2){
            sb.Append(word2[j]);
            j++;
        }
        return sb.ToString();
    }
}