 public class TimeMap
 {
     private Dictionary<string, List<(int timeStamp, string value)>> map; 

     public TimeMap()
     {
         map = new Dictionary<string, List<(int timeStamp, string value)>>();
     }

     public void Set(string key, string value, int timestamp)
     {
         if (!map.ContainsKey(key))
         {
             map[key] = new List<(int timeStamp, string value)>();
         }

         map[key].Add((timestamp, value));
     }

     public string Get(string key, int timestamp)
     {
         if (!map.ContainsKey(key))
         {
             return "";
         }

         List<(int, string)> timestamps = map[key];
         
         int left = 0, right = timestamps.Count - 1;
         string result = "";

         while (left <= right)
         {
             int mid = (left + right) / 2;

             if (timestamps[mid].Item1 == timestamp)
             {
                 return timestamps[mid].Item2;
             }
             else if (timestamps[mid].Item1 < timestamp)
             {
                 result = timestamps[mid].Item2;

                 left = mid + 1;
             }
             else
             {
                 right = mid - 1;
             }
         }

         return result;
     }
 }