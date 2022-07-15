namespace DS_Alg_ProblemSolving.Leetcode
{
    public class SquaresofaSortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            var output = new int[nums.Length];

            var leftPointer = 0;
            var rightPointer = nums.Length - 1;

            for (int i = rightPointer; i >= 0; i--)
            {
                if (nums[rightPointer] * nums[rightPointer] > nums[leftPointer] * nums[leftPointer])
                    output[i] = nums[rightPointer] * nums[rightPointer--];
                else
                    output[i] = nums[leftPointer] * nums[leftPointer++];
            }
            return output;
        }
    }
}