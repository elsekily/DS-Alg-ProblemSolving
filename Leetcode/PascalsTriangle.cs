using System.Collections.Generic;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var list = new List<IList<int>>();

            if (numRows == 0)
                return list;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        list.Add(new List<int>());
                        list[i].Add(1);
                    }
                    else if (j == i && j != 0)
                        list[i].Add(1);

                    else
                        list[i].Add(list[i - 1][j] + list[i - 1][j - 1]);
                }
            }
            return list;
        }
    }
}