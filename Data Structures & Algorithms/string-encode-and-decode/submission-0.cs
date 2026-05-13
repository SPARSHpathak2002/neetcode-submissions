public class Solution {

    public string Encode(IList<string> strs) {
        string es="";

        foreach(string i in strs){
            es += i;
            es += "%SP%";
        }
        
        return es;
    }

    public List<string> Decode(string s) {
        if(s == "%SP%") return [""];
        List<string> ans = new List<string>();
        string word = "";
        int i = 0;
        while(i < s.Length){
            string sub = s.Substring(i,4);
            if (sub == "%SP%"){
                ans.Add(word);
                word = "";
                i+=4;
            }
            else{
                word += s[i];
                i++;
            }
        }
        
        return ans;
    }
}
