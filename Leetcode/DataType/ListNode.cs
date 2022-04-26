namespace DS_Alg_ProblemSolving.Leetcode.DataType
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public override string ToString()
        {
            return "Value = " + val;
        }
    }
}