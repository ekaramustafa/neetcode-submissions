public class MinStack {
    private Stack<int> minStack;
    private Stack<int> stack;
    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.Count == 0 || val <= minStack.Peek()){
            minStack.Push(val);
        }
        else{
            minStack.Push(minStack.Peek());
        }
    }
    
    public void Pop() {
        if(stack.Count == 0)return;
        stack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
