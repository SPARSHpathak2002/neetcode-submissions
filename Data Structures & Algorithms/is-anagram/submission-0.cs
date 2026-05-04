public class Solution {
    public bool IsAnagram(string s, string t) {
        int sl = s.Length;
        int tl = t.Length;
        if(sl != tl) return false;

        int[] dict = new int[26];

        for(int i=0;i<sl;i++){
            dict[s[i]-'a']++;
        }
        for(int i=0;i<tl;i++){
            dict[t[i]-'a']--;
            if(dict[t[i]-'a'] < 0){
                return false;
            }
        }
        //chekck dict wih all 0;
        return true;
    }
}
