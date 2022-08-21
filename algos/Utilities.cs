namespace algos;

public class Utilities
{
    public static void SwapArray(int[] arr, int i, int j)
    {
        if (i == j) return;
        
        // Normal Swap
        // int temp= arr[j];
        // arr[j] = arr[i];
        // arr[i] = temp;
        
        // Turple Deconstruction
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }
}