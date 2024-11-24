using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walking_in_graph
{
    internal class Class1
    {
        public class NodeG
        {
            public List<NodeG> sasiedzi;
            int data;
            public NodeG(int liczba)
            {
                sasiedzi = new List<NodeG>();
                this.data = liczba;
            }
            public override string ToString()
            {
                return this.data.ToString();
            }
        }

        public class Hraf
        {
            private List<NodeG> nodes = new List<NodeG>();
            public List<NodeG> wszerz(NodeG start)
            {
                List<NodeG> odwiedzone = new List<NodeG>() { start };
                for(int i = 0; i < odwiedzone.Count; i++)
                {
                    var temp = odwiedzone[i];
                    foreach(var sasiad in temp.sasiedzi)
                    {
                        if(!odwiedzone.Contains(sasiad))
                        {
                            odwiedzone.Add(sasiad);
                        }
                    }
                }
                return odwiedzone;
            }
            public bool Join(List<NodeG> neighbours, NodeG node)
            {
                foreach(var neighbour in neighbours)
                {
                    if(!nodes.Contains(neighbour))
                    {
                        return false;
                    }
                }
                foreach(var neighbour in neighbours)
                {
                    neighbour.sasiedzi.Add(node);
                    node.sasiedzi.Add(neighbour);
                }
                nodes.Add(node);
                return true;
            }
            public void AddNode(NodeG node)
            {
                nodes.Add(node);
            }
        }
    }
}
