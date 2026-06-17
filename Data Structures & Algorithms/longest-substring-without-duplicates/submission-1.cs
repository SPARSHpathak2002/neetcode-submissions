public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int ans = 0,l=0;
        Dictionary <char,int> map = new Dictionary<char,int>();
        for(int r = 0 ; r < s.Length ; r++){
            if(map.ContainsKey(s[r])){               
                l = Math.Max(l, map[s[r]] + 1);
            }
            ans = Math.Max(r-l+1,ans);
            map[s[r]] = r;

        }
        return ans;
    }
}
