using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class LargestValueInTreeRow
    {
        public IList<int> LargestValues(TreeNode root)
        {
            var output = new List<int>();
            Traversal(root, 0, output);
            return output;
        }
        private void Traversal(TreeNode root, int level, IList<int> largestValues)
        {
            if (root == null)
                return;

            if (level == largestValues.Count)
                largestValues.Add(root.val);

            else
                largestValues[level] = Math.Max(largestValues[level], root.val);

            Traversal(root.left, level + 1, largestValues);
            Traversal(root.right, level + 1, largestValues);
        }
    }
}