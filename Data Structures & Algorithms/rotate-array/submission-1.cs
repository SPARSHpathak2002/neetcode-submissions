public class Solution {
    public void Rotate(int[] nums, int k) {
        int t = k > nums.Length ? k % nums.Length : k;
        int l = nums.Length -1;
        int s= 0;
        while(s<l){
            int tmp = nums[s];
            nums[s] = nums[l];
            nums[l] = tmp;
            s++;l--;
        }
        s = 0;
        l = t-1;
        while(s<l){
            int tmp = nums[s];
            nums[s] = nums[l];
            nums[l] = tmp;
            s++;l--;
        }
        s = t;
        l = nums.Length -1;;
        while(s<l){
            int tmp = nums[s];
            nums[s] = nums[l];
            nums[l] = tmp;
            s++;l--;
        }

    }
}