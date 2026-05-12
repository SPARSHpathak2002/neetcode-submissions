public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        PriorityQueue<int,int> maxHeap = new PriorityQueue<int,int>();
        Dictionary<int,int> hash = new Dictionary<int,int>();

        foreach(int i in nums){
             if (!hash.ContainsKey(i)) {
                hash[i] = 0;
            }

            hash[i]++;
        }

        foreach (var pair in hash) {

            maxHeap.Enqueue(pair.Key, -pair.Value);
        }

        int[] result = new int[k];

        for (int i = 0; i < k; i++) {

            result[i] = maxHeap.Dequeue();
        }

        return result;
    }
}
