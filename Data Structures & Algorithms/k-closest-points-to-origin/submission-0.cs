public class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        int[][] res = new int[k][];

        PriorityQueue<int, double> minHeap = new PriorityQueue<int, double>();

        for (int i = 0; i < points.Length; i++)
        {

            int num1  =  points[i][0];
            int num2  =  points[i][1];

            double distance = (Math.Sqrt(Math.Pow((num1 - 0),2) + Math.Pow((num2 - 0), 2)));

            minHeap.Enqueue(i, distance);
        }

        //foreach (int i in map.Keys)
        //{
        //    if(minHeap.Count > 0)
        //    {
        //        Console.WriteLine(minHeap.Dequeue());
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine($"{i} {map[i]}");
        //}

        for (int i = 0; i < k; i++)
        {
            int minIndex = minHeap.Dequeue();

            res[i] = new int[2] { points[minIndex][0], points[minIndex][1] };
        }

        return res;
    }
}