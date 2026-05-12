public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
          Dictionary<int, int> freq =
            new Dictionary<int, int>();

        // Count frequencies
        foreach (int num in nums) {

            if (!freq.ContainsKey(num)) {
                freq[num] = 0;
            }

            freq[num]++;
        }

        // Buckets
        List<int>[] buckets =
            new List<int>[nums.Length + 1];

        foreach (var pair in freq) {

            int frequency = pair.Value;

            if (buckets[frequency] == null) {
                buckets[frequency] = new List<int>();
            }

            buckets[frequency].Add(pair.Key);
        }

        // Collect top k
        List<int> result = new List<int>();

        for (int i = buckets.Length - 1;
             i >= 0 && result.Count < k;
             i--) {

            if (buckets[i] != null) {

                result.AddRange(buckets[i]);
            }
        }

        return result.Take(k).ToArray();

    }
}
