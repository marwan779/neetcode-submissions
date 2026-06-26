public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        int[][] pairs = new int[position.Length][];
        Stack<double> stack = new Stack<double>();

        for (int i = 0; i < position.Length; i++)
        {
            pairs[i] = new int[] { position[i], speed[i] };
        }
        Array.Sort(pairs, (a, b) => b[0].CompareTo(a[0]));

        foreach (var pair in pairs)
        {
            double time =(double) (target - pair[0]) / pair[1];
            stack.Push(time);
            if(stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1))
            {
                stack.Pop();
            }
        }

        return stack.Count();
    }
}