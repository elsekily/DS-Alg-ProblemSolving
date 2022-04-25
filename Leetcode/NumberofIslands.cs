namespace DS_Alg_ProblemSolving.Leetcode
{
    public class NumberofIslands
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null)
                return 0;

            var num = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        CheckNeighbours(grid, i, j);
                        num++;
                    }
                }
            }

            return num;
        }
        public void CheckNeighbours(char[][] grid, int i, int j)
        {
            if (i == grid.Length || i < 0 || j == grid[i].Length || j < 0)
                return;

            if (grid[i][j] == '1')
            {
                grid[i][j] = '0';

                CheckNeighbours(grid, i + 1, j);
                CheckNeighbours(grid, i - 1, j);
                CheckNeighbours(grid, i, j + 1);
                CheckNeighbours(grid, i, j - 1);
            }
        }
    }
}