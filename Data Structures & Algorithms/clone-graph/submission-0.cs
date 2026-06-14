/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null)return null;
        Dictionary<Node, Node> visited = new Dictionary<Node,Node>();


        return DeepCopy(node, visited);
    }


    private Node DeepCopy(Node node, Dictionary<Node, Node> visited){
        if(visited.ContainsKey(node)){
            return visited[node];
        }

        Node cloneNode = new Node(node.val);
        visited[node] = cloneNode;

        foreach(Node neighbor in node.neighbors){
            cloneNode.neighbors.Add(DeepCopy(neighbor, visited));
        }

        return cloneNode;
    }
}
