public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
    for (int l = 0; l < numbers.Length; l++) {
        for (int r = l + 1; r < numbers.Length; r++) {
            if (numbers[l] + numbers[r] == target) {
                return new int[] { l + 1, r + 1 }; 
            }
        }
    }
    return new int[] { -1, -1 }; 
    }
}
