namespace DS_Alg_ProblemSolving.Leetcode
{
    public class MinimumPathSum
    {
        public int MinPathSum(int[][] grid)
        {
            visited = new int[grid.Length, grid[0].Length];

            return Recurrsion(grid, 0, 0, 0);
        }
        private int[,] visited;
        private int Recurrsion(int[][] grid, int i, int j, int sum)
        {
            if (i == grid.Length || j == grid[i].Length)
                return -1;

            if (i == grid.Length - 1 && j == grid[i].Length - 1)
                return sum + grid[i][j];

            if (visited[i, j] != 0)
                return sum + visited[i, j];


            var rightSum = Recurrsion(grid, i, j + 1, sum + grid[i][j]);
            var downSum = Recurrsion(grid, i + 1, j, sum + grid[i][j]);

            if (rightSum == -1)
            {
                visited[i, j] = downSum - sum;
                return downSum;
            }
            if (downSum == -1)
            {
                visited[i, j] = rightSum - sum;
                return rightSum;
            }
            var output = Math.Min(rightSum, downSum);
            visited[i, j] = output - sum;


            return output;
        }
    }
}