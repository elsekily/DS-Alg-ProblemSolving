using System.Collections.Generic;
using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            return IsSymmetric(root, root);
        }
        public bool IsSymmetric(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
                return true;

            if ((root1 != null && root2 == null) || (root1 == null && root2 != null))
                return false;

            if (root1.val != root2.val)
                return false;

            return true && IsSymmetric(root1.left, root2.right) && IsSymmetric(root1.right, root2.left);
        }
    }
}