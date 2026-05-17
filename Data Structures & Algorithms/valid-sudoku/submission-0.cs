public class Solution {
    
    public bool IsValidSudoku(char[][] board) {
        int r = board[0].Length;
        int c = board.Length;
        // row checks
        for(int i = 0; i< c ; i++){
            HashSet<char> set = new HashSet<char>();
            for(int j = 0;j<r;j++){
                if ( set.Contains(board[i][j]) ){
                    Console.WriteLine("ROW Check - ROW -> {0} COL -> {1}",j,i);
                    return false;
                }
                if (board[i][j] != '.'){
                    set.Add(board[i][j]);
                }
            }
        }
       // column checks
        for(int i = 0; i< r ; i++){
            HashSet<char> set = new HashSet<char>();
            for(int j = 0;j<c;j++){
                if ( set.Contains(board[j][i]) ){
                    Console.WriteLine("COLUMN Check - ROW -> {0} COL -> {1}",i,j);
                    return false;
                }
                if (board[j][i] != '.'){
                    set.Add(board[j][i]);
                }
            }
        }
        //small squares check
        for (int row = 0; row < 9; row += 3) {

            for (int col = 0; col < 9; col += 3) {

                HashSet<char> set = new HashSet<char>();

                // Traverse inside box
                for (int i = row; i < row + 3; i++) {

                    for (int j = col; j < col + 3; j++) {

                        if (board[i][j] != '.') {

                            if (set.Contains(board[i][j])) {
                                return false;
                            }

                            set.Add(board[i][j]);
                        }
                    }
                }
            }
        }
        
        return true;
    }
}
