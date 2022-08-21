using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class FindBottomLeftTreeValue
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var current = queue.Peek();
            while (queue.Count != 0)
            {
                current = queue.Dequeue();

                if (current.right != null)
                    queue.Enqueue(current.right);

                if (current.left != null)
                    queue.Enqueue(current.left);
            }
            return current.val;
        }
    }
}