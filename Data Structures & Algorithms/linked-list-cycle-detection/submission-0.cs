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
     public bool HasCycle(ListNode head)
     {
         int index = 0;
         HashSet<ListNode> visited = new HashSet<ListNode>();
         ListNode current = head;

         while (current != null)
         {
             if (visited.Contains(current))
                 return true;
             else
                 visited.Add(current);

             current = current.next;
             index++;
         }

         return false;

     }
 }
