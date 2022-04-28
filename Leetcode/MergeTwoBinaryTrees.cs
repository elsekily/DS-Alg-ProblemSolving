using System.Collections.Generic;
using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null)
                return root2;

            if (root2 == null)
                return root1;

            var stack = new Stack<TreeNode[]>();

            stack.Push(new TreeNode[] { root1, root2 });

            while (stack.Count != 0)
            {
                var current = stack.Pop();
                if (current[0] == null || current[1] == null)
                    continue;

                current[0].val = current[0].val + current[1].val;

                if (current[0].left == null && current[1].left != null)
                {
                    current[0].left = current[1].left;
                }
                else
                {
                    stack.Push(new TreeNode[] { current[0].left, current[1].left });
                }
                if (current[0].right == null && current[1].right != null)
                {
                    current[0].right = current[1].right;
                }
                else
                {
                    stack.Push(new TreeNode[] { current[0].right, current[1].right });
                }
            }
            return root1;
        }
        public TreeNode MergeTreesRecursion(TreeNode root1, TreeNode root2)
        {
            if (root1 == null)
                return root2;

            if (root2 == null)
                return root1;

            root1.left = MergeTrees(root1.left, root2.left);
            root1.right = MergeTrees(root1.right, root2.right);

            root1.val = root1.val + root2.val;
            return root1;
        }
    }
}