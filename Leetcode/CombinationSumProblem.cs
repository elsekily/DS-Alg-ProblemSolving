namespace DS_Alg_ProblemSolving.Leetcode
{
    public class CombinationSumProblem
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            CombinationSum(target, candidates, 0, new LinkedList<int>(), result);
            return result;
        }
        private void CombinationSum(int target, int[] candidates,
                int i, LinkedList<int> combination, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(combination.ToList());
                return;
            }

            if (target < 0)
                return;

            for (; i < candidates.Length; i++)
            {
                combination.AddLast(candidates[i]);
                CombinationSum(target - candidates[i], candidates, i, combination, result);
                combination.RemoveLast();
            }
        }
    }
}