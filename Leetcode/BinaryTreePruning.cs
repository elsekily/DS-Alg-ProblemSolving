using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class BinaryTreePruning
    {
        public TreeNode PruneTree(TreeNode root)
        {
            if (root == null)
                return root;

            root.left = PruneTree(root.left);
            root.right = PruneTree(root.right);

            if (root.val == 0 && root.left == null && root.right == null)
                root = null;

            return root;
        }
    }
}