namespace DS_Alg_ProblemSolving.Leetcode
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var maxArea = 0;
            var leftPointer = 0;
            var rightPointer = height.Length - 1;

            while (leftPointer < rightPointer)
            {
                var currentArea = (rightPointer - leftPointer) * Math.Min(height[leftPointer], height[rightPointer]);
                maxArea = maxArea < currentArea ? currentArea : maxArea;

                if (height[leftPointer] > height[rightPointer])
                    rightPointer--;
                else
                    leftPointer++;
            }
            return maxArea;
        }
    }
}