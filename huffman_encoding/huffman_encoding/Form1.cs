using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace huffman_encoding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            var czestotliwosc = input.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            var root = Huffman.Tree(czestotliwosc);
            var codes = new Dictionary<char, string>();
            Huffman.generating(root, "", codes);
            var encoded = Huffman.encoding(input, codes);
            label2.Text = "Kod:\n" + string.Join("\n", codes.Select(kvp => $"{kvp.Key}: {kvp.Value}"));
            var decoded = Huffman.Decode(encoded, root);
            label3.Text = "S³owo: " + decoded;
        }
    }

    public class NodeG
    {
        public NodeG lewe;
        public NodeG prawe;
        public int data;
        public char? symbol;
    }

    public class Huffman
    {
        public static NodeG Tree(Dictionary<char, int> czestotliwosc)
        {
            var nodes = czestotliwosc.Select(kvp => new NodeG { symbol = kvp.Key, data = kvp.Value }).ToList();
            while (nodes.Count > 1)
            {
                nodes = nodes.OrderBy(n => n.data).ToList();
                var left = nodes[0];
                var right = nodes[1];
                var parent = new NodeG
                {
                    lewe = left,
                    prawe = right,
                    data = left.data + right.data,
                    symbol = null
                };
                nodes.RemoveRange(0, 2);
                nodes.Add(parent);
            }
            return nodes[0];
        }
        public static void generating(NodeG node, string code, Dictionary<char, string> codes)
        {
            if(node == null)
            {
                return;
            }
            if(node.symbol != null)
            {
                codes[node.symbol.Value] = code;
            }
            generating(node.lewe, code + "0", codes);
            generating(node.prawe, code + "1", codes);
        }

        public static string encoding(string text, Dictionary<char, string> codes)
        {
            return string.Join("", text.Select(c => codes[c]));
        }

        public static string Decode(string encodedText, NodeG root)
        {
            var result = "";
            var current = root;
            foreach(var bit in encodedText)
            {
                current = bit == '0' ? current.lewe : current.prawe;
                if(current.symbol != null)
                {
                    result += current.symbol;
                    current = root;
                }
            }
            return result;
        }
    }
}
