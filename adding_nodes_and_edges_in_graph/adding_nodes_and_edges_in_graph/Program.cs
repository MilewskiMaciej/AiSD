using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adding_nodes_and_edges_in_graph
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Graf1 graph = new Graf1();
            NodeG1 nodeA = new NodeG1("A");
            NodeG1 nodeB = new NodeG1("B");
            NodeG1 nodeC = new NodeG1("C");
            graph.AddEdge(new Edge(nodeA, nodeB, 1));
            graph.AddEdge(new Edge(nodeB, nodeC, 2));
            graph.AddEdge(new Edge(nodeA, nodeC, 3));
            var tree = graph.CreateTree();
            Console.WriteLine("Edges:");
            foreach (var edge in tree)
            {
                Console.WriteLine(edge);
            }
            Console.ReadLine();
        }
    }

    public class NodeG1
    {
        public string Data { get; }

        public NodeG1(string data)
        {
            Data = data;
        }
    }

    public class Edge : IComparable<Edge>
    {
        public NodeG1 Start { get; }
        public NodeG1 End { get; }
        public int Weight { get; }
        public Edge(NodeG1 start, NodeG1 end, int weight)
        {
            Start = start;
            End = end;
            Weight = weight;
        }

        public int CompareTo(Edge other)
        {
            return this.Weight.CompareTo(other.Weight);
        }

        public override string ToString()
        {
            return $"{Start.Data} - {End.Data}: {Weight}";
        }
    }

    public class Graf1
    {
        private List<NodeG1> nodes = new List<NodeG1>();
        private List<Edge> edges = new List<Edge>();

        public void AddEdge(Edge edge)
        {
            if (!nodes.Contains(edge.Start))
            {
                nodes.Add(edge.Start);
            }
            if (!nodes.Contains(edge.End))
            {
                nodes.Add(edge.End);
            }
            edges.Add(edge);
        }

        public List<Edge> CreateTree()
        {
            edges.Sort();
            var tree = new List<Edge>();
            var parent = new Dictionary<NodeG1, NodeG1>();
            foreach (var node in nodes)
            {
                parent[node] = node;
            }
            foreach (var edge in edges)
            {
                NodeG1 rootStart = FindRoot(edge.Start, parent);
                NodeG1 rootEnd = FindRoot(edge.End, parent);
                if (rootStart != rootEnd)
                {
                    tree.Add(edge);
                    parent[rootStart] = rootEnd;
                }
            }
            return tree;
        }

        private NodeG1 FindRoot(NodeG1 node, Dictionary<NodeG1, NodeG1> parent)
        {
            if (parent[node] != node)
            {
                parent[node] = FindRoot(parent[node], parent);
            }
            return parent[node];
        }
    }
}

