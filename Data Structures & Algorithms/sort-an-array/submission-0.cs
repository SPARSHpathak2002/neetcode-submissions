public class Solution {
    public void Swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
    public int Partition(int[] data,int low,int high){
        int pivot = data[high];
        int i =low-1;

        for (int j = low;j<high;j++){
            if(data[j]<pivot){
                i++;
                Swap(data,i,j);
            }
        }
        Swap(data,i+1,high);
        return i+1;
    }
    public void QuickSort(int[] data,int low,int high){
        if(low < high){
            int pivot = Partition(data,low,high);

            QuickSort(data,low,pivot-1);
            QuickSort(data,pivot+1,high);
        }
    }
    public int[] SortArray(int[] nums) {
        int len = nums.Length;
        QuickSort(nums,0,len-1);
        return nums;
    }
}