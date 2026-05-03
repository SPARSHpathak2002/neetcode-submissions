public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] arr = new int[nums.Length*2];
        int len = arr.Length;

        for(int i=0;i<(len/2);i++){
            arr[i] = nums[i];
            arr[i+(len/2)] = nums[i];
        }
        return arr;
    }
}