
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        var set = new HashSet<ListNode>();
        ListNode curr = head;

        while(curr != null)
        {
            if(set.Contains(curr)) return true;

            set.Add(curr);

            curr = curr.next; 
        }


        return false;
    }
}
