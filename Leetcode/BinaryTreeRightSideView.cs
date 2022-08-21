using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class BinaryTreeRightSideView
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var output = new List<int>();

            if (root == null)
                return output;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var current = queue.Peek();
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    current = queue.Dequeue();
                    if (i == 0)
                        output.Add(current.val);
                    if (current.right != null) queue.Enqueue(current.right);
                    if (current.left != null) queue.Enqueue(current.left);
                }
            }
            return output;
        }
        public IList<int> RightSideViewWithHelperObject(TreeNode root)
        {
            var output = new List<int>();

            if (root == null)
                return output;

            var queue = new Queue<obj>();
            queue.Enqueue(new obj() { Node = root, Level = 0 });

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                if (current.Node.left != null)
                {
                    queue.Enqueue(new obj() { Node = current.Node.left, Level = current.Level + 1 });
                }
                if (current.Node.right != null)
                {
                    queue.Enqueue(new obj() { Node = current.Node.right, Level = current.Level + 1 });
                }
                if (queue.Count == 0 || queue.Peek().Level != current.Level)
                    output.Add(current.Node.val);

            }
            return output;
        }
        private class obj
        {
            public TreeNode Node { get; set; }
            public int Level { get; set; }
        }
    }
}