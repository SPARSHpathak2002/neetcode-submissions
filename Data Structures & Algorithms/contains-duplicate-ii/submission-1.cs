public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> set = new HashSet<int>();
        for(int i= 0 ; i< nums.Length ; i++){
            if(set.Contains(nums[i])){
                return true;
            }
            if(set.Count >= k){
                set.Remove(nums[i-k]);
            }
            set.Add(nums[i]);
        }
        return false;
    }
}