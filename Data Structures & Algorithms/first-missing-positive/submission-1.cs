public class Solution {
    public int FirstMissingPositive(int[] nums) {
               int n = nums.Length;

        int i = 0;

        // Place numbers correctly
        while (i < n) {

            int correctIndex = nums[i] - 1;

            // Valid positive and not already correct
            if (nums[i] > 0 &&
                nums[i] <= n &&
                nums[i] != nums[correctIndex]) {

                // Swap
                int temp = nums[i];
                nums[i] = nums[correctIndex];
                nums[correctIndex] = temp;
            }
            else {

                i++;
            }
        }

        // Find first missing positive
        for (i = 0; i < n; i++) {

            if (nums[i] != i + 1) {

                return i + 1;
            }
        }

        return n + 1;
    }
}