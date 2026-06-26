/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) 
    {
        if (head == null) return null;

        List<int> values = new List<int>();
        ListNode temp = head;

        while (temp != null)
        {
            values.Add(temp.val);
            temp = temp.next;
        }

        // Create new reversed list
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        for (int i = values.Count - 1; i >= 0; i--)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        return dummy.next;
    }
}
