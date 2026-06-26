public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                current.next = new ListNode(list2.val);
                list2 = list2.next;
            }

            current = current.next;
        }

        // Append remaining nodes from either list
        while (list1 != null)
        {
            current.next = new ListNode(list1.val);
            list1 = list1.next;
            current = current.next;
        }

        while (list2 != null)
        {
            current.next = new ListNode(list2.val);
            list2 = list2.next;
            current = current.next;
        }

        return dummy.next;
    }
}
