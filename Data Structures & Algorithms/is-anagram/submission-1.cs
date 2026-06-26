public class Solution
{

    public bool AreDictionariesEqual(Dictionary<char, int> DS,  Dictionary<char, int> DT)
    {

        if (DS.Count != DT.Count)
            return false;

        foreach (var kvp in DS)
        {
            if (!DT.TryGetValue(kvp.Key, out int value))
                return false;

            if (!EqualityComparer<int>.Default.Equals(kvp.Value, value))
                return false;
        }

        return true;
    }
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> DS = new Dictionary<char, int>();
        Dictionary<char, int> DT = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if(DS.ContainsKey(c))
            {
                DS[c] = DS[c] + 1;
            }
            else
            {
                DS[c] = 1;
            }
        }

        foreach (char c in t)
        {
            
            if (DT.ContainsKey(c))
            {
                DT[c] = DT[c] + 1;
            }
            else
            {
                DT[c] = 1;
            }
        }


        //foreach (char i in DS.Keys)
        //{
        //    Console.WriteLine(i +" " +DS[i]);
        //}

        //Console.WriteLine("-------------------");

        //foreach (char i in DS.Keys)
        //{
        //    Console.WriteLine(i + " " + DT[i]);
        //}


        bool Result = AreDictionariesEqual(DS, DT);

        

        return Result;
    }
}