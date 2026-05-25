public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var uniqueTriplets = new HashSet<string>();
        var result = new List<List<int>>();

        int n = nums.Length;

        // Loop 1: First element
        for (int i = 0; i < n ; i++) {
            // Loop 2: Second element
            for (int j = i + 1; j < n; j++) {
                // Loop 3: Third element
                for (int k = j + 1; k < n; k++) {
                    if (nums[i] + nums[j] + nums[k] == 0) {
                        // Create and sort the triplet to create a unique key
                        var triplet = new List<int> { nums[i], nums[j], nums[k] };
                        triplet.Sort();

                        // Create a unique string key (e.g., "-1,0,1")
                        string key = $"{triplet[0]},{triplet[1]},{triplet[2]}";

                        // If this triplet layout hasn't been added yet, save it
                        if (!uniqueTriplets.Contains(key)) {
                            uniqueTriplets.Add(key);
                            result.Add(triplet);
                        }
                    }
                }
            }
        }

        return result;
    }
}
