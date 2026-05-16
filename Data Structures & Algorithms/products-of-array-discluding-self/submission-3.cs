public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int len = nums.Length;
        int[] pm = new int[len];
        int[] sm = new int[len];
        int[] ans = new int[len];
        pm[0] = 1;
        for(int i=1;i<len;i++){
            pm[i] = pm[i-1] * nums[i-1];
        }
        sm[len-1] = 1;
        for(int i = len-2;i>= 0 ;i--){
            sm[i] = sm[i+1] * nums[i+1];
        }
        for(int i=0;i<len;i++){
            ans[i] = pm[i] * sm[i];
        }
        return ans;
    }
}
