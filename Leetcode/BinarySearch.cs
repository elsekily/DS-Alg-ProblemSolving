namespace DS_Alg_ProblemSolving.Leetcode
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            var aPointer = 0;
            var bPointer = nums.Length - 1;

            while (aPointer < bPointer)
            {
                var mid = (bPointer - aPointer) / 2 + aPointer;

                if (nums[mid] == target)
                    return mid;
                else if (target > nums[mid])
                    aPointer = mid + 1;
                else
                    bPointer = mid - 1;
            }
            if (target == nums[aPointer])
                return aPointer;
            return -1;
        }
        public int SearchRec(int[] nums, int target)
        {
            if (nums.Length == 0)
                return -1;
            return SearchRec(nums, target, 0, nums.Length - 1);
        }
        private int SearchRec(int[] nums, int target, int start, int end)
        {
            var mid = start + (end - start) / 2;

            if (nums[mid] == target)
                return mid;

            else if (start == end && nums[mid] != target)
                return -1;
            else if (start > end)
                return -1;

            else if (target > nums[mid])
                return SearchRec(nums, target, mid + 1, end);

            else
                return SearchRec(nums, target, start, mid - 1);
        }
    }
}