namespace DS_Alg_ProblemSolving.Leetcode
{
    public class VersionControl
    {
        public int FirstBadVersion(int n)
        {
            var leftPointer = 1;
            var rightPointer = n;

            while (rightPointer > leftPointer)
            {
                var mid = leftPointer + (rightPointer - leftPointer) / 2;

                if (IsBadVersion(mid) && !IsBadVersion(mid - 1))
                    return mid;

                else if (!IsBadVersion(mid))
                    leftPointer = mid + 1;
                else
                    rightPointer = mid - 1;
            }
            return rightPointer;
        }
        private bool IsBadVersion(int version)
        {
            return version >= 20 ? true : false;
        }
    }
}