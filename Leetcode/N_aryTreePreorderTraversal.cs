using System.Collections.Generic;
using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class N_aryTreePreorderTraversal
    {
        public IList<int> Preorder(Node root)
        {
            var output = new List<int>();

            if (root == null)
                return output;

            var list = new LinkedList<Node>();
            list.AddFirst(root);

            while (list.Count != 0)
            {
                var current = list.First.Value;
                list.RemoveFirst();
                output.Add(current.val);

                for (int i = current.children.Count - 1; i >= 0 ; i--)
                {
                    list.AddFirst(current.children[i]);
                }
            }
            return output;
        }
    }
}