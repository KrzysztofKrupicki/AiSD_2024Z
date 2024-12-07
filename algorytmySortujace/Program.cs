class Program
{
    static void Main(string[] args)
    {
        int[] GenerujTablice(int n, int min, int max)
        {
            int[] result = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                result[i] = random.Next(min, max + 1);
            }
            return result;
        }

        void Pokaz(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        int[] BubleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            return array;
        }

        int[] CountingSort(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int[] countArray = new int[max + 1];
            for (int i = 0; i < array.Length; i++)
            {
                countArray[array[i]]++;
            }
            for (int i = 1; i < countArray.Length; i++)
            {
                countArray[i] += countArray[i - 1];
            }
            int[] result = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int position = countArray[array[i]] - 1;
                result[position] = array[i];
                countArray[array[i]]--;
            }
            return result;
        }

        int[] MergeSort(int[] array)
        {
            if (array.Length < 2) return array;
            int[] left = MergeSort(array.Take(array.Length / 2).ToArray());
            int[] right = MergeSort(array.Skip(array.Length / 2).ToArray());
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

        int[] QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int p = Partition(array, left, right);
                QuickSort(array, left, p - 1);
                QuickSort(array, p + 1, right);
            }
            return array;
        }

        int Partition(int[] array, int left, int right)
        {
            int p = array[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (array[j] < p)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            i++;
            int temp2 = array[right];
            array[right] = array[i];
            array[i] = temp2;
            return i;
        }

        Console.WriteLine("Generated array");
        int[] array = GenerujTablice(6, 0, 10);
        Pokaz(array);

        Console.WriteLine("BubbleSort");
        int[] arrayBS = BubleSort((int[])array.Clone());
        Pokaz(arrayBS);

        Console.WriteLine("InsertionSort");
        int[] arrayIS = InsertionSort((int[])array.Clone());
        Pokaz(arrayIS);

        Console.WriteLine("CountingSort");
        int[] arrayCS = CountingSort((int[])array.Clone());
        Pokaz(arrayCS);

        Console.WriteLine("MergeSort");
        int[] arrayMS = MergeSort((int[])array.Clone());
        Pokaz(arrayMS);

        Console.WriteLine("QuickSort");
        int[] arrayQS = QuickSort((int[])array.Clone(), 0, array.Length - 1);
        Pokaz(arrayQS);
    }
}