using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class FlattenBinaryTreetoLinkedList
    {
        public void Flatten(TreeNode root)
        {
            if (root == null)
                return;

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count != 0)
            {
                var current = stack.Pop();
                if (current.right != null)
                    stack.Push(current.right);

                if (current.left != null)
                {
                    current.right = current.left;
                    stack.Push(current.right);
                    current.left = null;
                }
                else
                {
                    if (stack.Count != 0)
                        current.right = stack.Peek();
                }
            }

        }
        public void FlattenRec(TreeNode root)
        {
            if (root == null)
                return;

            if (root.left != null)
            {
                var temp = root.right;

                root.right = root.left;
                root.left = null;

                var current = root.right;
                while (current.right != null)
                    current = current.right;

                current.right = temp;
            }
            Flatten(root.right);
        }
    }
}