using System.Threading.Tasks.Sources;

namespace Dijkstra_algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class NodeG1
        {
            public int id;
            public NodeG1(int id)
            {
                this.id = id;
            }
        }

        class Edge
        {
            public NodeG1 start;
            public NodeG1 end;
            public int weight;
            public Edge(NodeG1 start, NodeG1 end, int weight)
            {
                this.start = start;
                this.end = end;
                this.weight = weight;
            }
        }

        class Graf1
        {
            private List<NodeG1> nodes = new List<NodeG1>();
            private List<Edge> edges = new List<Edge>();
            public void addNode(NodeG1 node)
            {
                if (!nodes.Contains(node))
                {
                    nodes.Add(node);
                }
            }

            public void addEdge(Edge edge)
            {
                if (!edges.Contains(edge))
                {
                    edges.Add(edge);
                    addNode(edge.start);
                    addNode(edge.end);
                }
            }

            public List<Edge> getEdgesFrom(NodeG1 node)
            {
                return edges.FindAll(e => e.start.Equals(node));
            }

            public List<NodeG1> getNodes()
            {
                return nodes;
            }
        }

        class Dijkstra
        {
            public static (Dictionary<NodeG1, int> distances, Dictionary<NodeG1, NodeG1> previous) Run(Graf1 graph, NodeG1 start)
            {
                var distances = new Dictionary<NodeG1, int>();
                var previous = new Dictionary<NodeG1, NodeG1>();
                var priorityQueue = new SortedSet<(int, NodeG1)>();
                foreach (var node in graph.getNodes())
                {
                    distances[node] = int.MaxValue;
                    previous[node] = null;
                }
                distances[start] = 0;
                priorityQueue.Add((0, start));
                while (priorityQueue.Count > 0)
                {
                    var (currentDistance, currentNode) = priorityQueue.Min;
                    priorityQueue.Remove(priorityQueue.Min);
                    foreach (var edge in graph.getEdgesFrom(currentNode))
                    {
                        var neighbor = edge.end;
                        int newDistance = currentDistance + edge.weight;
                        if (newDistance < distances[neighbor])
                        {
                            priorityQueue.Remove((distances[neighbor], neighbor));
                            distances[neighbor] = newDistance;
                            previous[neighbor] = currentNode;
                            priorityQueue.Add((newDistance, neighbor));
                        }
                    }
                }
                return (distances, previous);
            }

            public static void printPath(Dictionary<NodeG1, NodeG1> previous, NodeG1 target)
            {
                var path = new Stack<NodeG1>();
                for (var at = target; at != null; at = previous[at])
                {
                    path.Push(at);
                }
                MessageBox.Show("Najkrotsza sciezka: " + string.Join(" -> ", path));
            }
        }

        private void RunDijkstra()
        {
            var graph = new Graf1();
            var nodeA = new NodeG1(1);
            var nodeB = new NodeG1(2);
            var nodeC = new NodeG1(3);
            var nodeD = new NodeG1(4);
            graph.addEdge(new Edge(nodeA, nodeB, 1));
            graph.addEdge(new Edge(nodeB, nodeC, 2));
            graph.addEdge(new Edge(nodeA, nodeC, 4));
            graph.addEdge(new Edge(nodeC, nodeD, 1));
            var (distances, previous) = Dijkstra.Run(graph, nodeA);
            foreach (var kys in distances)
            {
                MessageBox.Show($"Node {kys.Key}: Distance = {kys.Value}");
            }
            Dijkstra.printPath(previous, nodeD);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunDijkstra();
        }
    }
}
