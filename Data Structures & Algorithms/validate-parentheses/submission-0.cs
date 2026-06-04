public class Solution {
    public bool IsValid(string s) {
        Stack<char> store = new Stack<char>();
        for(int i=0; i < s.Length ; i++){
            if(s[i] == '(' || s[i] == '{' || s[i] == '['){
                store.Push(s[i]);
            }
            else{
                if (store.Count == 0) {
                    return false;
                }
                char top = store.Peek();
                                
                if ((s[i] == ')' && top == '(') ||
                    (s[i] == '}' && top == '{') ||
                    (s[i] == ']' && top == '[')) {
                    store.Pop(); 
                } else {
                    return false; 
                }
            }
        }
        return store.Count == 0;
    }
}
