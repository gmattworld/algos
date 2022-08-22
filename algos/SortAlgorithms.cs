namespace algos;

public static class SortAlgorithms
{
    /// <summary>
    /// Bubble sort algorithm
    /// </summary>
    /// <see cref="https://www.geeksforgeeks.org/bubble-sort/"/>
    /// <param name="arr"></param>
    public static void BubbleSort(int[] arr) {
        Console.WriteLine("<<<<<<<<<<<<<<<<<< Bubble Sort Algo >>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine($"Input: {string.Join(", ", arr)}");
        
        for (int j = 0; j <= arr.GetUpperBound(0); j++) {
            for (int i = 0; i < arr.GetUpperBound(0); i++) {
                if (arr[i] > arr[i + 1])
                {
                    Utilities.SwapArray(arr, i, i + 1);
                }
            }
        }
        
        Console.WriteLine($"Output: {string.Join(", ", arr)}");
    }
    
    /// <summary>
    /// Selection sort algorithm
    /// </summary>
    /// <see cref="https://www.geeksforgeeks.org/selection-sort/"/>
    /// <param name="arr"></param>
    public static void SelectionSort(int[] arr) {
        Console.WriteLine("<<<<<<<<<<<<<<<<<< Selection Sort Algo >>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine($"Input: {string.Join(", ", arr)}");
        
        for (int j = 0; j < arr.GetUpperBound(0); j++)
        {
            int minIndex = j;
            for (int i = j + 1; i <= arr.GetUpperBound(0); i++) {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
            }
            Utilities.SwapArray(arr, minIndex, j);
        }
        
        Console.WriteLine($"Output: {string.Join(", ", arr)}");
    }
    
    /// <summary>
    /// Insertion sort algorithm
    /// </summary>
    /// <see cref="https://www.geeksforgeeks.org/insertion-sort/"/>
    /// <param name="arr"></param>
    public static void InsertionSort(int[] arr) {
        Console.WriteLine("<<<<<<<<<<<<<<<<<< Insertion Sort Algo >>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine($"Input: {string.Join(", ", arr)}");
        
        for (int j = 1; j < arr.Length; j++)
        {
            int i;
            int key = arr[j];

            for (i = j; i > 0 && arr[i - 1] > key ; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[i] = key;
        }
        
        Console.WriteLine($"Output: {string.Join(", ", arr)}");
    }
    
    
    /// <summary>
    /// Shell sort algorithm
    /// </summary>
    /// <see cref="https://www.geeksforgeeks.org/insertion-sort/"/>
    /// <param name="arr"></param>
    public static void ShellSort(int[] arr) {
        Console.WriteLine("<<<<<<<<<<<<<<<<<< Shell Sort Algo >>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine($"Input: {string.Join(", ", arr)}");

        int gap = 1;
        while (gap < arr.Length / 3)
        {
            gap = 3 * gap + 1;
        }

        while (gap >= 1)
        {
            for (int j = gap; j < arr.Length; j++)
            {
                for (int i = j; i >= gap && arr[i] < arr[i - gap]; i -= gap)
                {
                    Utilities.SwapArray(arr, i, i - gap);
                }
            }
            
            gap /= 3;
        }

        Console.WriteLine($"Output: {string.Join(", ", arr)}");
    }
    
    
    /// <summary>
    /// Merge sort algorithm
    /// </summary>
    /// <see cref="https://www.geeksforgeeks.org/insertion-sort/"/>
    /// <param name="arr"></param>
    public static void MergeSort(int[] arr) {
        Console.WriteLine("<<<<<<<<<<<<<<<<<< Merge Sort Algo >>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine($"Input: {string.Join(", ", arr)}");

        int[] temp = new int[arr.Length];
        Sort(arr.GetLowerBound(0), arr.GetUpperBound(0));

        void Sort(int minIndex, int maxIndex)
        {
            if (maxIndex <= minIndex) return;
            
            int midIndex = (minIndex + maxIndex) / 2;
            
            Sort(minIndex, midIndex);
            Sort(minIndex + 1, maxIndex);

            Merge(minIndex, midIndex, maxIndex);
        }
        
        void Merge(int minIndex, int midIndex, int maxIndex)
        {
            int i = minIndex;
            int j = midIndex + 1;
            
            Array.Copy(arr, minIndex, temp, midIndex, maxIndex - minIndex - 1 );

            for (int k = minIndex; k <= maxIndex; k++)
            {
                if (i > midIndex) arr[k] = temp[j++];
                else if (j > maxIndex) arr[k] = temp[i++];
                else if (temp[j] < temp[i]) arr[k] = temp[j++];
                else arr[k] = temp[i++];
            }
        }

        Console.WriteLine($"Output: {string.Join(", ", arr)}");
    }
    
    
    /// <summary>
    /// Quick sort algorithm
    /// </summary>
    /// <see cref="https://www.geeksforgeeks.org/insertion-sort/"/>
    /// <param name="arr"></param>
    public static void QuickSort(int[] arr) {
        Console.WriteLine("<<<<<<<<<<<<<<<<<< Quick Sort Algo >>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine($"Input: {string.Join(", ", arr)}");

        Sort(arr.GetLowerBound(0), arr.GetUpperBound(0));

        void Sort(int minIndex, int maxIndex)
        {
            if (maxIndex <= minIndex) return;
            
            int midIndex = Partition(minIndex, maxIndex);
            Sort(minIndex, midIndex - 1);
            Sort(midIndex + 1, maxIndex);
        }
        
        int Partition(int minIndex, int maxIndex)
        {
            int i = minIndex;
            int j = maxIndex + 1;
            int pivot = arr[minIndex];

            while (true)
            {
                while (arr[++i] < pivot)
                {
                    if (i == maxIndex) break;
                }
                
                while (pivot < arr[--j])
                {
                    if (j == minIndex) break;
                }
                
                if (i >= j) break;
                
                Utilities.SwapArray(arr, i, j);
            }
            Utilities.SwapArray(arr, minIndex, j);
            return j;
        }

        Console.WriteLine($"Output: {string.Join(", ", arr)}");
    }
}