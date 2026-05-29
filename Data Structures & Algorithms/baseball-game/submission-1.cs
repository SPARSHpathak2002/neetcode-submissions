public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> store = new Stack<int>();
        int sum = 0;
        foreach(string i in operations){
            if(i == "+"){
                int a = store.Peek();
                store.Pop();
                int b = store.Peek();
                store.Pop();
                store.Push(b);
                store.Push(a);
                store.Push(a+b);
            }
            else if(i == "D"){
                int a = store.Peek();
                store.Pop();
                store.Push(a);
                store.Push(a*2);
            }
            else if(i == "C" ){
                store.Pop();
            }
            else{
                int n = int.Parse(i);
                store.Push(n);
            }
        }
        while(store.Count > 0){
            sum += store.Peek();
            store.Pop();
        }
        return sum;
    }
}