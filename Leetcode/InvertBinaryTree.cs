using System.Collections;
using System.Collections.Generic;
using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();

                var temp = current.left;
                current.left = current.right;
                current.right = temp;

                if (current.left != null)
                    queue.Enqueue(current.left);

                if (current.right != null)
                    queue.Enqueue(current.right);
            }



            return root;
        }
        public TreeNode InvertTreeRec(TreeNode root)
        {
            if (root == null)
                return root;

            var temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTreeRec(root.left);
            InvertTreeRec(root.right);

            return root;
        }
    }
}