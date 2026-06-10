/**
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int search(int l, int r) {
        int mid = l + (r - l) / 2;
        switch (guess(mid)) {
            case 0:
                return mid;
            case -1:
                return search(l, mid - 1);  // Removed 'int'
            case 1:
                return search(mid + 1, r);  // Removed 'int'
            default:
                throw new InvalidOperationException(
                    "Unexpected guess result.");  // Handles compiler error
        }
        return 0;
    }
    public int GuessNumber(int n) {
        return search(1, n);
    }
}