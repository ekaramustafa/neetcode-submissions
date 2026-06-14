/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

class Solution {
    public List<Integer> rightSideView(TreeNode root) {
        List<Stack<Integer>> storage = new ArrayList<Stack<Integer>>();

        List<Integer> result = new ArrayList<>();
        if(root == null){
            return result;
        }

        Queue<TreeNode> queue = new ArrayDeque<TreeNode>();
        queue.add(root);

        while(!queue.isEmpty()){
            int levelSize = queue.size();
            Stack<Integer> level = new Stack<Integer>();
            for (int i = 0; i<levelSize; i++){
                TreeNode node = queue.poll();
                level.push(node.val);

                if(node.left != null){
                    queue.add(node.left);
                }

                if(node.right != null){
                    queue.add(node.right);
                }
            }
            storage.add(level);
        }

        for(Stack<Integer> stack : storage){
            result.add(stack.pop());
        }

        return result;

    }
}
