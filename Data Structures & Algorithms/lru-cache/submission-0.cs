public class LRUCache
{
    int capacity;
    int usageCounter = 0;

    Dictionary<int, (int value, int lastUsage)> keyValuePairs;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        keyValuePairs = new Dictionary<int, (int, int)>();
    }

    public int Get(int key)
    {
        if (keyValuePairs.ContainsKey(key))
        {
            usageCounter++;
            var temp = keyValuePairs[key];
            temp.lastUsage = usageCounter;
            keyValuePairs[key] = temp;
            return temp.value;
        }
        else
        {
            return -1;
        }
    }

    public void Put(int key, int value)
    {
        usageCounter++;

        if (keyValuePairs.ContainsKey(key))
        {
            var temp = keyValuePairs[key];
            temp.value = value;
            temp.lastUsage = usageCounter;
            keyValuePairs[key] = temp;
        }
        else
        {
            if (keyValuePairs.Count >= capacity)
            {
                // Find the key with the least lastUsage manually
                int leastUsedKey = -1;
                int minUsage = int.MaxValue;

                foreach (var pair in keyValuePairs)
                {
                    if (pair.Value.lastUsage < minUsage)
                    {
                        minUsage = pair.Value.lastUsage;
                        leastUsedKey = pair.Key;
                    }
                }

                if (leastUsedKey != -1)
                {
                    keyValuePairs.Remove(leastUsedKey);
                }
            }

            keyValuePairs[key] = (value, usageCounter);
        }
    }
}
