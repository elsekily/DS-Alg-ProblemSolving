namespace DS_Alg_ProblemSolving.Leetcode
{
    public class UniquePathsIII
    {
        private int paths;
        public int UniquePathsIIIProblem(int[][] grid)
        {
            var remainningSquares = 0;
            int initialI = 0;
            int initialj = 0;
            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[i].Length; j++)
                {
                    remainningSquares = grid[i][j] == 0 ? remainningSquares + 1 : remainningSquares;
                    if (grid[i][j] == 1)
                    {
                        initialI = i;
                        initialj = j;
                    }
                }

            BackTracking(remainningSquares + 1, grid, initialI, initialj);
            return paths;
        }
        private void BackTracking(int remainningSquares, int[][] grid, int i, int j)
        {
            if (i < 0 || j < 0 || i == grid.Length || j == grid[0].Length || grid[i][j] == -1 || grid[i][j] == 3)
                return;

            if (grid[i][j] == 2 && remainningSquares == 0)
            {
                paths++;
                return;
            }
            else if (grid[i][j] == 2 && remainningSquares != 0)
                return;

            else
            {
                grid[i][j] = 3;
                BackTracking(remainningSquares - 1, grid, i + 1, j);
                BackTracking(remainningSquares - 1, grid, i - 1, j);
                BackTracking(remainningSquares - 1, grid, i, j + 1);
                BackTracking(remainningSquares - 1, grid, i, j - 1);
                grid[i][j] = 0;
            }

        }
    }
}