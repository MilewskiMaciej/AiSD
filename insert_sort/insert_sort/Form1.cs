namespace insert_sort
{
    public partial class Form1 : Form
    {
        private void insert_sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j >= 1; j--)
                {
                    if (arr[j - 1] != 0 & arr[j - 1] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            int[] numbers = [7, 2, 8, 3, 1, 4, 5];
            insert_sort(numbers);
        }
    }
}
