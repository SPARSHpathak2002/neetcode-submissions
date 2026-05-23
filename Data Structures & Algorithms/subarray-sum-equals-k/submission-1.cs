public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int ans = 0;
        Dictionary<int,int> map = new Dictionary<int,int>();
        map[0] = 1;
        int sum = 0;
        for(int i = 0;i < nums.Length ;i++){
            sum += nums[i];
            int needed = sum - k;
            if(map.ContainsKey(needed)){
                ans += map[needed];
            }
            if(!map.ContainsKey(sum)){
                map[sum] = 0;
            }
            map[sum]++;
        }
        return ans;
    }
}