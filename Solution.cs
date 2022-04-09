/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public (bool valid, int depth) dfs(TreeNode root) {
        if (root == null) {
            return (true, 0);
        }
        
        var left = dfs(root.left);
        var right = dfs(root.right);
        
        var balanced = left.valid && right.valid && (Math.Abs(left.depth - right.depth) <= 1);
        
        return (balanced, 1 + Math.Max(left.depth, right.depth));
    }
    
    public bool IsBalanced(TreeNode root) {
        return dfs(root).valid;
    }
}
