using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            var start = new ListNode(0);
            var cstart = start;
            var mid = new ListNode(0);
            var cmid = mid;
            while (head != null)
            {
                var temp = head.next;
                if (head.val < x)
                {
                    cstart.next = head;
                    cstart = cstart.next;
                }
                else
                {
                    cmid.next = head;
                    cmid = cmid.next;
                }
                head = temp;
            }
            cmid.next = null;
            cstart.next = mid.next;
            return start.next;
        }
    }
}