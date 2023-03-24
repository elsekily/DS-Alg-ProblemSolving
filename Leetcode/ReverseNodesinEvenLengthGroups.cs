using DS_Alg_ProblemSolving.Leetcode.DataType;

namespace DS_Alg_ProblemSolving.Leetcode
{
    public class ReverseNodesinEvenLengthGroups
    {
        public ListNode ReverseEvenLengthGroups(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            var groupLength = 1;
            var index = 1;

            var current = head;
            var LastHead = head;


            while (current != null)
            {
                if (index == groupLength)
                {
                    if (groupLength % 2 == 0)
                    {
                        var nextNode = current.next;
                        current.next = null;
                        var temp = LastHead.next;
                        LastHead.next = Reverse(LastHead.next, nextNode);
                        current = nextNode;
                        index = 1;
                        groupLength++;
                        LastHead = temp;
                        continue;
                        //Reverse logic 
                    }

                    index = 0;
                    groupLength++;
                    LastHead = current;

                }
                current = current.next;
                index++;
            }

            if ((index - 1) % 2 == 0)
            {
                LastHead.next = Reverse(LastHead.next, null);
            }

            return head;
        }
        private ListNode Reverse(ListNode head, ListNode last)
        {
            while (head != null)
            {
                var temp = head.next;
                head.next = last;
                last = head;
                head = temp;
            }
            return last;
        }
    }
}