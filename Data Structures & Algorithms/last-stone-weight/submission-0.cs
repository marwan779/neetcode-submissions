public class MaxHeap
{
    private List<int> Heap;

    public int Count => Heap.Count;

    public MaxHeap(int[] array)
    {
        Heap = new List<int>(array);
        BuildHeap();
    }

    private void BuildHeap()
    {
        int lastNonLeafNodeIndex = (Heap.Count / 2) - 1;
        for (int i = lastNonLeafNodeIndex; i >= 0; i--)
        {
            HeapifyDown(i);
        }
    }

    private void HeapifyDown(int index)
    {
        int largest = index;
        int left = 2 * index + 1;
        int right = 2 * index + 2;

        if (left < Heap.Count && Heap[left] > Heap[largest])
            largest = left;

        if (right < Heap.Count && Heap[right] > Heap[largest])
            largest = right;

        if (largest != index)
        {
            Swap(index, largest);
            HeapifyDown(largest);
        }
    }

    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parent = (index - 1) / 2;

            if (Heap[index] > Heap[parent])
            {
                Swap(index, parent);
                index = parent;
            }
            else
                break;
        }
    }

    public void Insert(int value)
    {
        Heap.Add(value);
        HeapifyUp(Heap.Count - 1);
    }

    public int ExtractMax()
    {
        

        int max = Heap[0];
        Heap[0] = Heap[Heap.Count - 1];
        Heap.RemoveAt(Heap.Count - 1);

        HeapifyDown(0);
        return max;
    }

    public int Peek()
    {
        if (Heap.Count == 0)
            return 0;

        return Heap[0];
    }

    private void Swap(int i, int j)
    {
        int temp = Heap[i];
        Heap[i] = Heap[j];
        Heap[j] = temp;
    }

    public void PrintHeap()
    {
        Console.WriteLine(string.Join(", ", Heap));
    }
}


public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        MaxHeap maxHeap = new MaxHeap(stones);
        int s1, s2, val;

        while (maxHeap.Count > 0)
        {
            if (maxHeap.Count == 1)
                return maxHeap.Peek();

            s1 = maxHeap.ExtractMax();
            s2 = maxHeap.ExtractMax();


            val = s1 - s2;
            maxHeap.Insert(val);

        }

        return 0;
    }
}