using System.Collections.Concurrent;

namespace algorytmySortujace
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int[] GenerujLosowaTablice(int n, int min, int max)
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

            int[] BubbleSort(int[] array)
            {
                int[] result = (int[])array.Clone();
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (result[j] > result[j + 1])
                        {
                            int temp = result[j];
                            result[j] = result[j + 1];
                            result[j + 1] = temp;
                        }
                    }
                }
                return result;
            }

            int[] InsertionSort(int[] array)
            {
                int[] result = (int[])array.Clone();
                for (int i = 1; i < array.Length; i++)
                {
                    int key = result[i];
                    int j = i - 1;
                    while (j >= 0 && result[j] > key)
                    {
                        result[j + 1] = result[j];
                        j--;
                    }
                    result[j + 1] = key;
                }
                return result;
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
                if (array.Length < 2)
                {
                    return array;
                }
                int mid = array.Length / 2;
                int[] left = MergeSort(array.Take(mid).ToArray());
                int[] right = MergeSort(array.Skip(mid).ToArray());
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
                        int temp1 = array[j];
                        array[j] = array[i];
                        array[i] = temp1;
                    }
                }
                int temp2 = array[right];
                array[right] = array[i + 1];
                array[i + 1] = temp2;
                return i + 1;
            }

            int[] tablica = GenerujLosowaTablice(15, 0, 20);
            Console.WriteLine("Wygenerowana tablica");
            Pokaz(tablica);

            int[] tablicaPoBubbleSort = BubbleSort(tablica);
            Console.WriteLine("\nBubbleSort");
            Pokaz(tablicaPoBubbleSort);

            int[] tablicaPoInsertionSort = InsertionSort(tablica);
            Console.WriteLine("\nInsertionSort");
            Pokaz(tablicaPoInsertionSort);

            int[] tablicaPoCountingSort = CountingSort(tablica);
            Console.WriteLine("\nCountingSort");
            Pokaz(tablicaPoCountingSort);

            int[] tablicaPoMergeSort = MergeSort(tablica);
            Console.WriteLine("\nMergeSort");
            Pokaz(tablicaPoMergeSort);

            int[] tablicaPoQuickSort = QuickSort((int[])tablica.Clone(), 0, tablica.Length - 1);
            Console.WriteLine("\nQuickSort");
            Pokaz(tablicaPoQuickSort);

            Console.WriteLine("Wygenerowana tablica");
            Pokaz(tablica);
        }
    }
}