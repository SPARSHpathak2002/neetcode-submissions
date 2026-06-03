public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        while(left < right){
            if(s[left] == s[right]){
                left++;
                right--;
            }
            else{
                return (isPalindrome(left+1,right,s) || isPalindrome(left,right-1,s));
            }
        }
        return true;
    }
    public bool isPalindrome(int l, int r, string s){
        while(l <r){
            if (s[l] != s[r]){
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}
