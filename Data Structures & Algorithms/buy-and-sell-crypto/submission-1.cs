public class Solution {
    public int MaxProfit(int[] prices) {
        int l=0,r=1;
        int ans = 0;
        while(r < prices.Length){
            if(prices[l] < prices[r]){
                int tmp = prices[r] - prices[l];
                ans = Math.Max(ans,tmp);
            }
            else{
                l = r;
            }
            r++;
        }
        return ans;
    }
}
