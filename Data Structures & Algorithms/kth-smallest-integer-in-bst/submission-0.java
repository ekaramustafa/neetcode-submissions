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
    public int kthSmallest(TreeNode root, int k) {

        Queue<Integer> queue = new ArrayDeque<>();

        dfs(queue, root);
        int element = -1;
        while(k>0){
            element = queue.poll();
            k--;
        }

        return element;
    }

    private static void dfs(Queue<Integer> queue, TreeNode root) {
        if (root == null) return;

        dfs(queue, root.left);     
        queue.add(root.val);       
        dfs(queue, root.right);
    }
}
