public class Solution
{
	public int LongestConsecutive(int[] nums)
	{
		if(nums.Length == 0) return 0;

		Dictionary<int, int> HashSet = new Dictionary<int, int>();
		int Result = 0, NextConnectedElement = 0;	

		for(int i = 0; i < nums.Length; i++)
		{
			HashSet[nums[i]] = i; // initialize the HashSet's keys with the elements of the array
		}

		foreach(int i in HashSet.Keys)
		{
			if(!HashSet.ContainsKey(i-1)) // if the HashsSet has no element-1  
			{                             // (meaning that the element) is a starting point
				NextConnectedElement = 0;
				while(HashSet.ContainsKey(i + NextConnectedElement))  // check of i + NextConnectedElement is in the HashSet
				{                                                    // increment the NextConnectedElement to get the number
					NextConnectedElement++;							// of the connected elements that starts from i 
				}
			}

			Result = Math.Max(Result, NextConnectedElement); // get the maximum connected elements in the HashSet
		}

		return Result;
	}
}