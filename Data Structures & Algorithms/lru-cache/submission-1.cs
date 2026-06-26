 public class LRUCache
 {
     int capacity;
     Dictionary<int, LinkedListNode<(int key, int value)>> cache;
     LinkedList<(int key, int value)> nodes;
     public LRUCache(int capacity)
     {
         this.capacity = capacity;
         cache = new Dictionary<int, LinkedListNode<(int key, int value)>>();
         nodes = new LinkedList<(int key, int value)>();
     }

     public int Get(int key)
     {
         if (cache.ContainsKey(key))
         {
             var node = cache[key];
             nodes.Remove(node);
             nodes.AddLast(node);
             cache[key] = node;
             return node.Value.value;
         }
         else
             return -1;
     }

     public void Put(int key, int value)
     {
         if (cache.ContainsKey(key))
         {
             var node = cache[key];
             nodes.Remove(node);
             node.Value = (key, value);
             nodes.AddLast(node);
             cache[key] = node;
         }
         else
         {
             if (cache.Count == capacity)
             {
                 var node = nodes.First;
                 cache.Remove(node.Value.key);
                 nodes.Remove(node);
             }

             var newNode = new LinkedListNode<(int key, int value)>((key, value));
             nodes.AddLast(newNode);
             cache[key] = newNode;

         }
     }

 }
