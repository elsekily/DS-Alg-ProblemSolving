using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class LinkedListCycle
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
                return null;

            var current = head;
            var set = new HashSet<ListNode>();

            while (current != null)
            {
                if (set.Contains(current))
                    return current;
                else
                {
                    set.Add(current);
                    current = current.next;
                }
            }

            return null;
        }
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;

            var slow = head;
            var fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    slow = head;
                    while (slow != fast)
                    {
                        slow = slow.next;
                        fast = fast.next;
                    }
                }
            }

            return false;
        }
    }
}