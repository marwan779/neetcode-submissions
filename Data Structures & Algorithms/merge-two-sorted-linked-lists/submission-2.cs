public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 != null) return list2;
        if (list2 == null && list1 != null) return list1;
        if (list1 == null && list2 == null) return null;

        ListNode a = list1, b = list2, curr = new ListNode(0);
        ListNode head = curr;

        while (a != null && b != null)
        {
            if (a.val <= b.val)
            {
                curr.next = new ListNode(a.val);
                a = a.next;
            }
            else
            {
                curr.next = new ListNode(b.val);
                b = b.next;
            }

            curr = curr.next;
        }

        while (a != null)
        {
            curr.next = new ListNode(a.val);
            a = a.next;
            curr = curr.next;
        }

        while (b != null)
        {
            curr.next = new ListNode(b.val);
            b = b.next;
            curr = curr.next;

        }

        return head.next;
    }
}