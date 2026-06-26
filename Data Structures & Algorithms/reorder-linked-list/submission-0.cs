  public class Solution
  {
      public void ReorderList(ListNode head)
      {
          if (head == null) return;
          int l, r;
          List<ListNode> list = new List<ListNode>();
          ListNode current = head;

          while (current != null)
          {
              list.Add(current);
              current = current.next;
          }

          current = head;

          l = 0;
          r = list.Count - 1;

          while (l < r)
          {
              list[l].next = list[r];
              l++;
            if (l >= r) break;
              list[r].next = list[l];
              r--;
          }

          list[l].next = null;
      }
  }