public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int ans = 0;
        for(int i = 0 ; i < nums.Length ; i++){
            int s = 0;
            for(int j = i ; j< nums.Length ; j++){
               s += nums[j];
               if(s == k) ans++;
               
            }         
        }
        return ans;
    }
}