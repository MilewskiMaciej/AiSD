namespace bubble_sort
{
    public partial class Form1 : Form
    {
        private List<int> tab = new List<int>();
        private List<int> nb = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            int[] numbersBefore = nb.ToArray();
            nb.Add(number);
            tab.Add(number);
            button2.Visible = true;
            label4.Text = "Stan tablicy: [" + string.Join(", ", numbersBefore) + "]";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numbers = tab.ToArray();
            bubble_sort(numbers);
            label1.Text = "Posortowana tablica: [" + string.Join(", ", numbers) + "]";
        }
        private void bubble_sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
