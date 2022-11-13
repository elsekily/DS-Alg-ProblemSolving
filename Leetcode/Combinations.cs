using System.Net.Sockets;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            var output = new List<IList<int>>();
            Adder(1, n, k, new LinkedList<int>(), output);
            return output;
        }
        private void Adder(int start, int n, int k, LinkedList<int> list, List<IList<int>> output)
        {
            if (list.Count == k)
            {
                output.Add(list.ToList());
            }
            else
            {
                for (int i = start; i <= n; i++)
                {
                    list.AddLast(i);
                    Adder(i + 1, n, k, list, output);
                    list.RemoveLast();
                }
            }
        }
    }
}