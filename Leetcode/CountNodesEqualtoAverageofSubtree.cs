using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class CountNodesEqualtoAverageofSubtree
    {
        public int AverageOfSubtree(TreeNode root)
        {
            SubTreeSum(root);
            return count;
        }
        private int count;
        private int[] SubTreeSum(TreeNode root)
        {
            if (root == null)
                return new int[] { 0, 0 };

            var left = SubTreeSum(root.left);
            var right = SubTreeSum(root.right);
            var subTreeSum = root.val + left[0] + right[0];
            var subTreeCount = 1 + left[1] + right[1];

            count = (int)(subTreeSum / subTreeCount) == root.val ? count + 1 : count;


            return new int[] { subTreeSum, subTreeCount };
        }
    }
}