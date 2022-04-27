using System.Collections.Generic;
using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var output = new List<int>();
            if (root == null)
                return output;

            var current = root;
            var stack = new Stack<TreeNode>();

            while (stack.Count != 0 || current != null)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                current = stack.Pop();
                output.Add(current.val);
                current = current.right;
            }
            return output;
        }
    }
}