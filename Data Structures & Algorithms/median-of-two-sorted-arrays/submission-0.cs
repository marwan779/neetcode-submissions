public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int m = nums1.Length;
        int n = nums2.Length;
        int  Mid= 0; 
        double MidSum = 0;
        bool OddOrEven = false;
        var List  = new List<int>();
        List.AddRange(nums1);
        List.AddRange(nums2);
        List.Sort();
        OddOrEven = (List.Count %2 == 0 ? true : false);
        Mid = List.Count / 2;
        if( OddOrEven )
        {
            MidSum = ((List[Mid] + List[Mid-1])/2.0);
        }
        else
        {
            MidSum = List[Mid];
        }
        return MidSum;
    }
}