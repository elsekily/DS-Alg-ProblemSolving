using System.Collections.Generic;

namespace DS_Alg_ProblemSolving.Leetcode.DataType
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
        public override string ToString()
        {
            return "Value = " + val;
        }
    }
}