public class TimeMap
{
    private Dictionary<string, Dictionary<int, List<string>>> map; 

    public TimeMap()
    {
        map = new Dictionary<string, Dictionary<int, List<string>>>();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (!map.ContainsKey(key))
        {
            map[key] = new Dictionary<int, List<string>>();
        }

        if (!map[key].ContainsKey(timestamp))
        {
            map[key][timestamp] = new List<string>();
        }
        map[key][timestamp].Add(value);
    }

    public string Get(string key, int timestamp)
    {
        if (!map.ContainsKey(key))
        {
            return "";
        }

        Dictionary<int, List<string>> timestamps = map[key];
        int seen = 0;

        foreach (var time in timestamps.Keys)
        {
            if (time <= timestamp)
            {
                seen = time;
            }
        }
        return seen == 0 ? "" : timestamps[seen][^1];
    }
}