using System.Text.RegularExpressions;
using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
                return false;

            var slowPointer = head;
            var fastPointer = head;

            while (fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }
            slowPointer = ReverseLinkedList(slowPointer);

            while (slowPointer != null)
            {
                if (slowPointer.val != head.val)
                    return false;

                slowPointer = slowPointer.next;
                head = head.next;
            }
            return true;
        }
        private ListNode ReverseLinkedList(ListNode head)
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