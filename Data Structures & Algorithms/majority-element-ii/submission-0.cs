public class Solution {
    public List<int> MajorityElement(int[] nums) {
        Dictionary<int, int> store = new Dictionary<int, int>();
        foreach (int i in nums) {
            if(!store.ContainsKey(i)) {
                store[i] = 0;
            }
            store[i] += 1;
        }
        int len = nums.Length / 3;
        List<int> ans = new List<int>();
        foreach (KeyValuePair<int, int> i in store) {
            if (i.Value > len) {
                ans.Add(i.Key);
            }
        }
        return ans;
    }
}