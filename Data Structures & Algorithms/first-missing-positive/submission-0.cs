public class Solution {
    public int FirstMissingPositive(int[] nums) {
        Array.Sort(nums);
        int missing = 1;
        for(int i = 0;i<nums.Length;i ++){
            
            if(nums[i] < 1){
                continue;
            }
            if(nums[i] < missing){
                continue;
            }
            if(nums[i] == missing){
                missing++;
            }
            else{
                break;
            }

        }
        return missing;
    }
}