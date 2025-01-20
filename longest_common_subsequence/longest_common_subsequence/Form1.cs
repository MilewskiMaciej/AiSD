namespace longest_common_subsequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void nwp(string str1, string str2)
        {
            int m = str1.Length;
            int n = str2.Length;
            int[,] tab = new int[m + 1, n + 1];
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        tab[i, j] = tab[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        tab[i, j] = Math.Max(tab[i - 1, j], tab[i, j - 1]);
                    }
                }
            }
            int len = tab[m, n];
            char[] ch = new char[len];
            int index = len - 1;
            int x = m;
            int y = n;
            while (x > 0 && y > 0)
            {
                if (str1[x - 1] == str2[y - 1])
                {
                    ch[index--] = str1[x - 1];
                    x--;
                    y--;
                }
                else if (tab[x - 1, y] > tab[x, y - 1])
                {
                    x--;
                }
                else
                {
                    y--;
                }
            }
            label1.Text = new string(ch);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            string str2 = textBox2.Text;
            nwp(str1, str2);
        }
    }
}
