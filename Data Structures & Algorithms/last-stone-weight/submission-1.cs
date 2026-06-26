public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();

        foreach (int stone in stones)
            maxHeap.Enqueue(stone, -stone);

        int s1, s2, val;

        while (maxHeap.Count > 0)
        {
            if (maxHeap.Count == 1)
                return maxHeap.Peek();

            s1 = maxHeap.Dequeue();
            s2 = maxHeap.Dequeue();


            val = s1 - s2;
            maxHeap.Enqueue(val, -val);

        }

        return 0;
    }
}