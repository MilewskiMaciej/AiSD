namespace making_list
{
    public partial class Form1 : Form
    {
        private List list;
        public Form1()
        {
            InitializeComponent();
            list = new List();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                list.addFirst(number);
                label1.Text = "Stan listy: {" + list.ToString() + "}";
            }
            else
            {
                MessageBox.Show("Wprowadzono b³êdne dane.");
            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int number))
            {
                list.addLast(number);
                label1.Text = "Stan listy: {" + list.ToString() + "}";
            }
            else
            {
                MessageBox.Show("Wprowadzono b³êdne dane.");
            }
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.removeFirst();
            label1.Text = "Stan listy: {" + list.ToString() + "}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.removeLast();
            label1.Text = "Stan listy: {" + list.ToString() + "}";
        }
    }
}
