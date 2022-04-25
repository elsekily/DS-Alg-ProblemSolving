using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return head;

            ListNode tail = null;
            while (head != null)
            {
                var temp = head.next;
                head.next = tail;
                tail = head;
                head = temp;
            }

            return tail;
        }
    }
}