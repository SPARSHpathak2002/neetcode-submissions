public class Solution {
    public int MaxArea(int[] heights) {
        int n = heights.Length;
        int water = 0;
        for(int i = 0; i< n-1;i++){
            for(int j= i+1;j<n;j++){
                water = Math.Max(water,Math.Min(heights[i],heights[j])*(j-i));
            }
        }

        return water;
    }
}
