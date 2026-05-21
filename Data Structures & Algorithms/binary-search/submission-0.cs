public class Solution {
    public int BinarySearch(int[] nums, int l, int r, int target) {
    if (l > r) {
        return -1; 
    }

    int mid = l + (r - l) / 2;

    if (nums[mid] == target) {
        return mid;
    }
    else if (nums[mid] > target) {
        return BinarySearch(nums, l, mid - 1, target);
    }
    else {
        return BinarySearch(nums, mid + 1, r, target);
    }
}

public int Search(int[] nums, int target) {
    if (nums == null || nums.Length == 0) {
        return -1;
    }
    int l = 0;
    int r = nums.Length - 1;
    return BinarySearch(nums, l, r, target);
}
}
