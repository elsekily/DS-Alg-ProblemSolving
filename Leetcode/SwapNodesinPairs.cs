using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class SwapNodesinPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            var current = new ListNode(0);
            var pointer = current;



            while (head != null && head.next != null)
            {
                pointer.next = head.next;
                var temp = pointer.next.next;
                pointer.next.next = head;
                head.next = temp;
                head = head.next;
                pointer = pointer.next.next;
            }
            return current.next;

        }
    }
}