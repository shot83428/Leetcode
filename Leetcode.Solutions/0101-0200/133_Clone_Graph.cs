namespace Leetcode.Solutions_133
{
    public class Solution_133
    {
        public Node CloneGraph(Node node)
        {
            Dictionary<int, Node> dic = new Dictionary<int, Node>();
            Queue<Node> queue = new Queue<Node>();
            if (node == null)
                return null;
            queue.Enqueue(node);

            while (queue.TryDequeue(out var item))
            {
                if (!dic.ContainsKey(item.val))
                {
                    dic.Add(item.val, new Node(item.val));
                }
                var curr = dic[item.val];

                foreach (var neighbor in item.neighbors)
                {
                    if (!dic.ContainsKey(neighbor.val))
                    {
                        dic.Add(neighbor.val, new Node(neighbor.val));
                        queue.Enqueue(neighbor);
                    }
                    curr.neighbors.Add(dic[neighbor.val]);
                }
            }

            return dic[node.val];
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
