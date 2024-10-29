namespace trees_and_roots
{
    public partial class Form1 : Form
    {
        private List list;
        private List.BST bst;
        public Form1()
        {
            InitializeComponent();
            list = new List();
            bst = new List.BST();
            label1.AutoSize = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                list.addLast(number);
                bst.add(number);
                drawTree();
                label2.Text = "Stan listy: {" + list.ToString() + "}";
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Wprowadzono b³êdne dane.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.removeFirst();
            label2.Text = "Stan listy: {" + list.ToString() + "}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.removeLast();
            label2.Text = "Stan listy: {" + list.ToString() + "}";
        }
        private void drawTree()
        {
            label1.Controls.Clear();
            if(bst.root != null)
            {
                drawNode(bst.root, label1.Width / 2, 20, label1.Width / 4);
            }
        }
        private void drawNode(List.NodeT node, int x, int y, int offset)
        {
            if(node == null)
            {
                return;
            }
            Label labelNode = new Label
            {
                Text = node.data.ToString(),
                Size = new Size(30, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(x - 15, y - 15)
            };
            label1.Controls.Add(labelNode);
            if(node.left != null)
            {
                drawNode(node.left, x - offset, y + 50, offset / 2);
            }
            if(node.right != null)
            {
                drawNode(node.right, x + offset, y + 50, offset / 2);
            }
        }
    }
}
