namespace algos;

public static class Algorithms
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
}