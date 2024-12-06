using System;
using System.Diagnostics;

namespace program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] tab = null;

        private int[] GenerateRandomArray(int n, int min, int max)
        {
            tab = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                tab[i] = random.Next(min, max + 1);
            }
            return tab;
        }

        static string TabToString(int[] tab)
        {
            if (tab != null)
            {
                return string.Join(",", tab);
            }
            else
            {
                MessageBox.Show("Tablica nie istnieje.");
                return null;
            }
        }
        private int[] ConvertTextToArray(string input)
        {
            return input.Split(',').Select(int.Parse).ToArray();
        }

        private void ButtonConvertToArray_Click(object sender, EventArgs e)
        {
            tab = ConvertTextToArray(inputTextToConvert.Text);
        }

        private void ButtonGenerateRandomArray_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDownSize.Value;
            int min = (int)numericUpDownMinValue.Value;
            int max = (int)numericUpDownMaxValue.Value;
            tab = GenerateRandomArray(n, min, max);
        }

        private void ButtonShowArray_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TabToString(tab));
        }
        int[] BubbleSort(int[] tab)
        {
            var sortedArray = (int[])tab.Clone();
            int n = sortedArray.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedArray[j] > sortedArray[j + 1])
                    {
                        (sortedArray[j + 1], sortedArray[j]) = (sortedArray[j], sortedArray[j + 1]);
                    }
                }
            }
            return sortedArray;
        }

        private void ButtonBubbleSort_Click(object sender, EventArgs e)
        {
            if (tab != null)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var sortedArray = BubbleSort((int[])tab.Clone());
                sw.Stop();
                var result = TabToString(sortedArray);
                if (sortedArray.Length < 16)
                {
                    inputResultOfSorting.Text = result;
                }
                else
                {
                    var displayResult = sortedArray.Take(15).ToArray();
                    inputResultOfSorting.Text = TabToString(displayResult);
                }
                labelSortingTime.Text = "Czas sortowania: " + sw.ElapsedMilliseconds + " ms";
            }
            else
            {
                MessageBox.Show("Tablica nie istnieje.");
            }
        }

        int[] InsertionSort(int[] tab)
        {
            var sortedArray = (int[])tab.Clone();
            int n = sortedArray.Length;
            for (int i = 1; i < n; i++)
            {
                int current = sortedArray[i];
                int j = i - 1;
                while (j >= 0 && sortedArray[j] > current)
                {
                    sortedArray[j + 1] = sortedArray[j];
                    j--;
                }
                sortedArray[j + 1] = current;
            }
            return sortedArray;
        }

        private void ButtonInsertionSort_Click(object sender, EventArgs e)
        {
            if (tab != null)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var sortedArray = InsertionSort((int[])tab.Clone());
                sw.Stop();
                var result = TabToString(sortedArray);
                if (sortedArray.Length < 16)
                {
                    inputResultOfSorting.Text = result;
                }
                else
                {
                    var displayResult = sortedArray.Take(15).ToArray();
                    inputResultOfSorting.Text = TabToString(displayResult);
                }
                labelSortingTime.Text = "Czas sortowania: " + sw.ElapsedMilliseconds + " ms";
            }
            else
            {
                MessageBox.Show("Tablica nie istnieje.");
            }
        }
        int[] MergeSort(int[] tab)
        {
            if (tab.Length <= 1)
                return tab;

            int mid = tab.Length / 2;
            int[] left = MergeSort(tab.Take(mid).ToArray());
            int[] right = MergeSort(tab.Skip(mid).ToArray());

            return Merge(left, right);
        }

        int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                result[k++] = left[i++];
            }
            while (j < right.Length)
            {
                result[k++] = right[j++];
            }
            return result;
        }

        private void ButtonMergeSort_Click(object sender, EventArgs e)
        {
            if (tab != null)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var sortedArray = MergeSort((int[])tab.Clone());
                sw.Stop();
                var result = TabToString(sortedArray);
                if (sortedArray.Length < 16)
                {
                    inputResultOfSorting.Text = result;
                }
                else
                {
                    var displayResult = sortedArray.Take(15).ToArray();
                    inputResultOfSorting.Text = TabToString(displayResult);
                }
                labelSortingTime.Text = "Czas sortowania: " + sw.ElapsedMilliseconds + " ms";
            }
            else
            {
                MessageBox.Show("Tablica nie istnieje.");
            }
        }

        int[] QuickSort(int[] tab, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(tab, left, right);
                QuickSort(tab, left, pivot - 1);
                QuickSort(tab, pivot + 1, right);
            }
            return tab;
        }

        int Partition(int[] tab, int left, int right)
        {
            int pivot = tab[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (tab[j] < pivot)
                {
                    i++;
                    (tab[i], tab[j]) = (tab[j], tab[i]);
                }
            }

            (tab[i + 1], tab[right]) = (tab[right], tab[i + 1]);
            return i + 1;
        }

        private void ButtonQuickSort_Click(object sender, EventArgs e)
        {
            if (tab != null)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var sortedArray = QuickSort((int[])tab.Clone(), 0, tab.Length - 1);
                sw.Stop();
                var result = TabToString(sortedArray);
                if (sortedArray.Length < 16)
                {
                    inputResultOfSorting.Text = result;
                }
                else
                {
                    var displayResult = sortedArray.Take(15).ToArray();
                    inputResultOfSorting.Text = TabToString(displayResult);
                }
                labelSortingTime.Text = "Czas sortowania: " + sw.ElapsedMilliseconds + " ms";
            }
            else
            {
                MessageBox.Show("Tablica nie istnieje.");
            }
        }
    }
}
