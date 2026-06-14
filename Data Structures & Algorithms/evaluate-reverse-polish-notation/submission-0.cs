public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        for(int i =0;i<tokens.Length;i++){
            if(tokens[i].Equals("+")){
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if (tokens[i].Equals("-")){
                int first = stack.Pop();
                int second = stack.Pop();
                stack.Push(second - first);
            }
            else if (tokens[i].Equals("/")){
                int first = stack.Pop();
                int second = stack.Pop();
                stack.Push(second / first);
            }
            else if (tokens[i].Equals("*")){
                stack.Push(stack.Pop() * stack.Pop());
            }
            else{
                stack.Push(int.Parse(tokens[i]));
            }
        }
        return stack.Pop();
    }
}
