public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 1) return 0;
        int ans = 0;
        for(int i=1 ; i < prices.Length ; i++){
            if(prices[i] > prices[i-1]){
                ans += prices[i] - prices[i-1];
            }
        }
        return ans;
    }
}