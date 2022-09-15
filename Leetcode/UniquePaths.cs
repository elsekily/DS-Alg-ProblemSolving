using System.Net.NetworkInformation;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class UniquePaths
    {
        private int[][] grid;
        public int UniquePathsProblem(int m, int n)
        {
            grid = new int[m][];
            for (int i = 0; i < m; i++)
            {
                grid[i] = new int[n];
            }
            return UniquePathsRec(m - 1, n - 1);

        }
        private int UniquePathsRec(int m, int n)
        {
            if (n == 0 && m == 0)
                return 1;

            if (n < 0 || m < 0)
                return 0;

            if (grid[m][n] != 0)
                return grid[m][n];
            var result = UniquePathsRec(m - 1, n) + UniquePathsRec(m, n - 1);
            grid[m][n] = result;

            return result;
        }
        private Dictionary<string, int> dict = new Dictionary<string, int>();
        public int UniquePathsUsingString(int m, int n)
        {
            var s = string.Format("{0},{1}", m, n);
            if (dict.ContainsKey(s))
                return dict[s];

            if (n == 1 && m == 1)
                return 1;

            if (n < 1 || m < 1)
                return 0;

            dict.Add(s, UniquePathsRecss(m - 1, n) + UniquePathsRecss(m, n - 1));

            return dict[s];
        }
    }
}