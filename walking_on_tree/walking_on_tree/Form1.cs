namespace walking_on_tree
{
    public partial class Form1 : Form
    {
        private List.BST bst = new List.BST();
        private List list = new List();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                bst.add(number);
                DisplayBST();
            }
            else
            {
                MessageBox.Show("Podano nieprawid³owe dane.");
            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int number))
            {
                bst.remove(number);
                DisplayBST();
            }
            else
            {
                MessageBox.Show("Podano nieprawid³owe dane.");
            }
            textBox1.Clear();
        }
        private void DisplayBST()
        {
            listBox1.Items.Clear();
            DisplayBSTInOrder(bst.root);
        }
        private void DisplayBSTInOrder(List.NodeT node)
        {
            if(node != null)
            {
                DisplayBSTInOrder(node.left);
                listBox1.Items.Add(node.data);
                DisplayBSTInOrder(node.right);
            }
        }
    }
}
