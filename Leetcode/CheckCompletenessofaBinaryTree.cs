using System.Net.Security;
using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class CheckCompletenessofaBinaryTree
    {
        public bool IsCompleteTree(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var nullDetected = false;

            while (queue.Count != 0)
            {
                root = queue.Dequeue();

                if (root == null)
                    nullDetected = true;
                else
                {
                    if (nullDetected) return false;
                    queue.Enqueue(root.left);
                    queue.Enqueue(root.right);
                }
            }
            return true;
        }
    }
}