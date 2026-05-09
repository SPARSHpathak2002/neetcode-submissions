public class Solution {
    public int MajorityElement(int[] nums) {
        int can = 0;
        int count = 0;
        foreach(int n in nums){
            if(count == 0){
                can = n;
            }
            if(can == n){
                count++;
            }
            else{
                count--;
            }
        }
        return can;
    }
}