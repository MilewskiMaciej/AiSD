using System.Diagnostics;

namespace sorting_application
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
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            label4.Text = "Stan tablicy: [" + string.Join(", ", numbersBefore) + "]";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numbers = tab.ToArray();
            bubble_sort(numbers);
            label1.Text = "Posortowana tablica: [" + string.Join(", ", numbers) + "]";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] numbers = tab.ToArray();
            insert_sort(numbers);
            label1.Text = "Posortowana tablica: [" + string.Join(", ", numbers) + "]";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] numbers = tab.ToArray();
            merge_sort(numbers, 0, numbers.Length - 1);
            label1.Text = "Posortowana tablica: [" + string.Join(", ", numbers) + "]";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] numbers = tab.ToArray();
            quick_sort(numbers, 0, numbers.Length - 1);
            label1.Text = "Posortowana tablica: [" + string.Join(", ", numbers) + "]";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] numbers = tab.ToArray();
            selection_sort(numbers);
            label1.Text = "Posortowana tablica: [" + string.Join(", ", numbers) + "]";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] numbers = tab.ToArray();
            counting_sort(numbers);
            label1.Text = "Posortowana tablica: [" + string.Join(", ", numbers) + "]";
        }

        private void bubble_sort(int[] arr)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
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
            watch.Stop();
            label5.Text = "Czas trwania sortowania: " + watch.ElapsedTicks + " ms";
        }

        private void insert_sort(int[] arr)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int temp = arr[i];
                int popr = i - 1;
                while (popr >= 0 && arr[popr] > temp)
                {
                    arr[popr + 1] = arr[popr];
                    popr -= 1;
                }
                arr[popr + 1] = temp;
            }
            watch.Stop();
            label5.Text = "Czas trwania sortowania: " + watch.ElapsedTicks + " ms";
        }

        private void merging(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] lArr = new int[n1];
            int[] rArr = new int[n2];
            for (int i = 0; i < n1; i++)
            {
                lArr[i] = arr[l + i];
            }
            for (int i = 0; i < n2; i++)
            {
                rArr[i] = arr[m + 1 + i];
            }
            int iL = 0;
            int iR = 0;
            int iM = l;
            while (iL < n1 && iR < n2)
            {
                if (lArr[iL] <= rArr[iR])
                {
                    arr[iM] = lArr[iL];
                    iL++;
                }
                else
                {
                    arr[iM] = rArr[iR];
                    iR++;
                }
                iM++;
            }
            while (iL < n1)
            {
                arr[iM] = lArr[iL];
                iL++;
                iM++;
            }
            while (iR < n2)
            {
                arr[iM] = rArr[iR];
                iR++;
                iM++;
            }
        }

        private void merge_sort(int[] arr, int l, int r)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            if (l < r)
            {
                int m = (l + r) / 2;
                merge_sort(arr, l, m);
                merge_sort(arr, m + 1, r);
                merging(arr, l, m, r);
            }
            watch.Stop();
            label5.Text = "Czas trwania sortowania: " + watch.ElapsedTicks + " ms";
        }

        private void quick_sort(int[] arr, int l, int r)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            if (l < r)
            {
                int p = arr[r];
                int i = l - 1;
                for (int j = l; j < r; j++)
                {
                    if (arr[j] <= p)
                    {
                        i++;
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                int tempS = arr[i + 1];
                arr[i + 1] = arr[r];
                arr[r] = tempS;
                quick_sort(arr, l, i);
                quick_sort(arr, i + 2, r);
            }
            watch.Stop();
            label5.Text = "Czas trwania sortowania: " + watch.ElapsedTicks + " ms";
        }

        private void selection_sort(int[] arr)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int iMin = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[iMin])
                    {
                        iMin = j;
                    }
                }
                int temp = arr[iMin];
                arr[iMin] = arr[i];
                arr[i] = temp;
            }
            watch.Stop();
            label5.Text = "Czas trwania sortowania: " + watch.ElapsedTicks + " ms";
        }

        private void counting_sort(int[] arr)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int n = arr.Length;
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            int[] count = new int[max + 1];
            for (int i = 0; i < n; i++)
            {
                count[arr[i]]++;
            }
            int temp = 0;
            int Cn = count.Length;
            for (int i = 0; i < Cn; i++)
            {
                while (count[i] > 0)
                {
                    arr[temp] = i;
                    temp++;
                    count[i]--;
                }
            }
            watch.Stop();
            label5.Text = "Czas trwania sortowania: " + watch.ElapsedTicks + " ms";
        }
    }
}
