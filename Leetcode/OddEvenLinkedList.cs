using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return head;

            var current = head;
            var evenHead = head.next;
            var even = evenHead;

            while (even != null && even.next != null)
            {
                current.next = even.next;
                current = current.next;
                even.next = current.next;
                even = even.next;
            }
            current.next = evenHead;

            return head;

        }
        public ListNode OddEvenListDeletingEven(ListNode head)
        {
            if (head == null)
                return head;

            var current = head;
            var evenHead = new ListNode(0);
            var evenHeadPointer = evenHead;

            while (current != null && current.next != null)
            {
                evenHeadPointer.next = current.next;
                evenHeadPointer = evenHeadPointer.next;

                current.next = current.next.next;
                current = current.next;

            }
            evenHeadPointer.next = null;
            current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = evenHead.next;

            return head;
        }
    }
}