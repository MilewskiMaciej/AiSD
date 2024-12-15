namespace Dijkstra_algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class NodeG1
        {
            public String name;
            public List<Edge> edges = new List<Edge>();
        }

        public class Edge
        {
            public NodeG1 target;
            public int weight;
        }

        public Dictionary<NodeG1, Tuple<int, NodeG1>> algorithm(NodeG1 start)
        {
            var tabelka = new Dictionary<NodeG1, Tuple<int, NodeG1>>();
            var zbiorS = new HashSet<NodeG1>();
            foreach (var node in getAllNodes())
            {
                tabelka[node] = Tuple.Create(int.MaxValue, (NodeG1)null);
            }
            tabelka[start] = Tuple.Create(0, (NodeG1)null);
            while (zbiorS.Count < tabelka.Count)
            {
                var current = tabelka.Where(e => !zbiorS.Contains(e.Key)).OrderBy(e => e.Value.Item1).FirstOrDefault().Key;
                if (current == null)
                {
                    break;
                }
                zbiorS.Add(current);
                foreach (var edge in current.edges)
                {
                    var target = edge.target;
                    if(!tabelka.ContainsKey(target))
                    {
                        tabelka[target] = Tuple.Create(int.MaxValue, (NodeG1)null);
                    }
                    var newDistance = tabelka[current].Item1 + edge.weight;
                    if (newDistance < tabelka[target].Item1)
                    {
                        tabelka[target] = Tuple.Create(newDistance, current);
                    }
                }
            }
            return tabelka;
        }
        private List<NodeG1> getAllNodes()
        {
            return new List<NodeG1>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nodeA = new NodeG1
            {
                name = "A"
            };
            var nodeB = new NodeG1
            {
                name = "B"
            };
            var nodeC = new NodeG1
            {
                name = "C"
            };
            nodeA.edges.Add(new Edge { target = nodeB, weight = 1 });
            nodeB.edges.Add(new Edge { target = nodeC, weight = 2 });
            nodeA.edges.Add(new Edge { target = nodeC, weight = 4 });
            var nodes = new List<NodeG1>() { nodeA, nodeB, nodeC };
            var results = algorithm(nodeA);
            foreach(var result in results)
            {
                var node = result.Key;
                var distance = result.Value.Item1;
                var previous = result.Value.Item2;
                listBox1.Items.Add($"Wêze³: {node.name}, odleg³oœæ: {distance}");
            }
        }
    }
}
