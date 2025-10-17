namespace CreationalPatterns.Prototypes.TreeCopy;

public class Node() : IPrototype
{
    private List<Node> _nodes = [];

    public void Add(Node node)
    {
        _nodes.Add(node);
    }
    public void Pop()
    {
        if (_nodes.Count > 0)
        {
            _nodes.RemoveAt(_nodes.Count - 1);
        }
    }

    public Node Clone()
    {
        Node node = new Node();
        foreach (Node copiableNode in _nodes)
        {
            node.Add(copiableNode.Clone());
        }
        return node;
    }
}
