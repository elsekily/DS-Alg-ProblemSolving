using System;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class TwoSum
    {
        public int[] TwoSums(int[] nums, int target)
        {
            var aPointer = 0;
            var bPointer = nums.Length - 1;

            while (aPointer < bPointer)
            {
                if (nums[aPointer] + nums[bPointer] > target)
                    bPointer--;

                else if (nums[aPointer] + nums[bPointer] < target)
                    aPointer++;

                else
                    break;
            }
            return new int[] { aPointer, bPointer };
        }
    }
}