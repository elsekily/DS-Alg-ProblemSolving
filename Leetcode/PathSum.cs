using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;

            var nodeStack = new Stack<TreeNode>();
            var sumStack = new Stack<int>();
            nodeStack.Push(root);
            sumStack.Push(root.val);

            while (nodeStack.Count != 0)
            {
                var current = nodeStack.Pop();
                var currentSum = sumStack.Pop();

                if (current.left == null && current.right == null && targetSum == currentSum)
                    return true;

                if (current.left != null)
                {
                    nodeStack.Push(current.left);
                    sumStack.Push(currentSum + current.left.val);
                }

                if (current.right != null)
                {
                    nodeStack.Push(current.right);
                    sumStack.Push(currentSum + current.right.val);
                }
            }
            return false;
        }
        public bool HasPathSumRec(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;

            return HasPathSumRec(root, targetSum, 0);
        }
        private bool HasPathSumRec(TreeNode root, int targetSum, int currentSum)
        {
            if (root.left == null && root.right == null && targetSum == currentSum + root.val)
                return true;

            currentSum += root.val;
            var result = false;

            if (root.left != null)
                result = result || HasPathSumRec(root.left, targetSum, currentSum);

            if (root.right != null && result != true)
                result = result || HasPathSumRec(root.right, targetSum, currentSum);

            return result;
        }
    }
}