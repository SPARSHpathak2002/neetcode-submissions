public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right) {
            int sum = numbers[left] + numbers[right];

            if (sum == target) {
                return new int[] { left + 1, right + 1 };  // Fixed: 1-indexed output
            }

            if (sum > target) {
                right--;  // Fixed: Move right pointer down if sum is too large
            } else {
                left++;  // Fixed: Added missing semicolon and moved left pointer up
            }
        }

        return new int[] { -1, -1 };
    }
}
