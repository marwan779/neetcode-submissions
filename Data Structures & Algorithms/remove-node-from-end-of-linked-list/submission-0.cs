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

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int index = 0;
        List<ListNode> nodes = new List<ListNode>();
        ListNode current = head;

        while (current != null)
        {
            nodes.Add(current);
            current = current.next;
        }

        index = (nodes.Count) - n;

        if (index == 0)
        {
            head = head.next;
        }
        else
        {
            nodes[index - 1].next = nodes[index].next;
            nodes[index].next = null;

        }



        return head;
    }
}



