public class Solution {
    public int Search(int[] nums, int l, int r, int target) {
        if (l > r) {
            return l;
        }

        int mid = l + (r - l) / 2;

        if (nums[mid] == target) {
            return mid;
        }

        if (nums[mid] > target) {
            return Search(nums, l, mid - 1, target);
        }

        return Search(nums, mid + 1, r, target);
    }
    public int SearchInsert(int[] nums, int target) {
        return Search(nums, 0, nums.Length - 1, target);
    }
}