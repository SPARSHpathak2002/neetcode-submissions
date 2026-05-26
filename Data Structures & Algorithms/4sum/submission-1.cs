public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        List<List<int>> ans = new List<List<int>>();
        Array.Sort(nums);
        int n = nums.Length;

        for (int j = 0; j < n - 3; j++) {
            // Skip duplicates for the first number
            if (j > 0 && nums[j] == nums[j - 1]) continue;

            for (int i = j + 1; i < n - 2; i++) { 
                if (i > j + 1 && nums[i] == nums[i - 1]) continue;

                int left = i + 1;
                int right = n - 1;

                while (left < right) {
    
                    long sum = (long)nums[j] + nums[i] + nums[left] + nums[right];

                    if (sum == target) {
                        ans.Add(new List<int> { nums[j], nums[i], nums[left], nums[right] });
                        
                        left++;
                        right--;
                        
                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                    } 
                    else if (sum < target) { 
                        left++;
                    } 
                    else {
                        right--;
                    }
                }
            }
        }
        return ans;
    }
}
