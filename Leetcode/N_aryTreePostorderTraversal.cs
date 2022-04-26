using System.Collections.Generic;
using System.Linq;
using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class N_aryTreePostorderTraversal
    {
        public IList<int> Postorder(Node root)
        {
            var output = new List<int>();

            if (root == null)
                return output;

            var stack = new Stack<Node>();
            var visited = new HashSet<Node>();
            stack.Push(root);


            while (stack.Count != 0)
            {
                var current = stack.Peek();
                if (current.children == null || current.children.Count == 0 || visited.Contains(current))
                {
                    output.Add(stack.Pop().val);
                }
                else
                {
                    for (int i = current.children.Count - 1; i >= 0; i--)
                    {
                        stack.Push(current.children[i]);
                    }
                    visited.Add(current);

                }
            }
            return output;
        }

        public IList<int> PostorderLinkedList(Node root)
        {
            var output = new LinkedList<int>();

            if (root == null)
                return output.ToArray();

            var stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count != 0)
            {
                var current = stack.Pop();
                output.AddFirst(current.val);
                if (current.children != null)
                {
                    foreach (var child in current.children)
                    {
                        stack.Push(child);
                    }
                }
            }



            return output.ToList();


        }

    }
}