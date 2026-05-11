public class Solution {
    public void Swap(int[] arr,int a, int b){
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
    public void SortColors(int[] nums) {
        int i = 0;
        int j = nums.Length-1;
        int k = 0;
        while(k<=j){
            if(nums[k] == 0){
                Swap(nums,k,i);
                i++;
                k++;             
            }
            else if(nums[k] == 1){
                k++;
            }
            else{
                Swap(nums,k,j);
                j--;
                 
            }
        }
    }
}