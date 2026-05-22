public class Solution {
    public int SingleNumber(int[] nums) {
        int s = nums[0];
        for(int i = 1;i < nums.Length;i++){
            s = s ^ nums[i];
        }
        return s;
    }
}
