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

    public static int Factorial(int num)
    {
        if (num < 0) return 0;
        if (num == 0) return 1;
        int factorial = 1;
        for (int i = num; i > 1; i--)
        {
            factorial *= i;
        }
        
        return factorial;
    }
    
    public static int FactorialRecursion(int num)
    {
        if (num < 0) return 0;
        if (num == 0) return 1;
        
        return num * FactorialRecursion(num - 1);
    }
}