namespace DS_Alg_ProblemSolving.Leetcode
{
    public class AllPathsFromSourcetoTarget
    {
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            var result = new List<IList<int>>();
            Rec(graph, 0, result, new LinkedList<int>());
            return result;
        }
        private void Rec(int[][] graph, int i, IList<IList<int>> result, LinkedList<int> list)
        {
            if (i == graph.Length - 1)
            {
                list.AddLast(i);
                result.Add(list.ToList());
                list.RemoveLast();
                return;
            }
            for (int j = 0; j < graph[i].Length; j++)
            {
                list.AddLast(i);
                Rec(graph, graph[i][j], result, list);
                list.RemoveLast();
            }

        }
    }
}