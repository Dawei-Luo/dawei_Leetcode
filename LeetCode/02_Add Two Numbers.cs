public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution_02
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode list = new ListNode(0);
        ListNode result = list;
        int c = 0;
        while (l1 != null || l2 != null || c > 0)
        {
            int num = 0;
            if (l1 != null)
            {
                num += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                num += l2.val;
                l2 = l2.next;
            }
            num += c;
            Console.WriteLine(c);
            list.next = new ListNode(num % 10);
            c = num / 10;
            list = list.next;
        }
        return result.next;
    }
}