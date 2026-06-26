public class Solution
{
	public int[] TopKFrequent(int[] nums, int k)
	{
        if(nums.Length == 0) return new int[] {};
        else if(nums.Length == 1 ) return new int[] {nums[0]};

		Dictionary<int, List<int>> HashTable = new Dictionary<int, List<int>>();
		List<List<int>> Temp = new List<List<int>>();

		foreach (int x in nums)
		{
			if (!HashTable.ContainsKey(x))
			{
				HashTable.Add(x, new List<int>());
				HashTable[x].Add(x);
			}
			else
			{
				HashTable[x].Add(x);
			}
		}

		foreach(List<int> list in HashTable.Values)
		{
			Temp.Add(list);
		}

		Temp = Temp.OrderByDescending(x => x.Count()).ToList();
		
		int[] Result = new int[k];

		for(int i = 0; i < k; i++)
		{
			Result[i] = Temp[i][0];
		}
		return Result;	
	}
}