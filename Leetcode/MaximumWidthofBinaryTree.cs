using System.Collections.Generic;
using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class MaximumWidthofBinaryTree
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            var list = new List<int[]>();
            GetLevels(root, 0, 0, list);
            return list.Max(x => x[1]) + 1;
        }
        private void GetLevels(TreeNode root, int level, int index, List<int[]> levelsData)
        {
            if (root == null)
                return;

            if (levelsData.Count == level)
                levelsData.Add(new int[] { index, 0 });

            var diff = index - levelsData[level][0];
            levelsData[level][1] = Math.Max(diff, levelsData[level][1]);
            GetLevels(root.left, level + 1, index * 2, levelsData);
            GetLevels(root.right, level + 1, index * 2 + 1, levelsData);
        }
    }
}