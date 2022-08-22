namespace algos;

public class AlgoTests
{
    /// <summary>
    /// Given an integer array nums, return true if any value appears at least twice in the array,
    /// and return false if every element is distinct.
    /// </summary>
    /// <example>
    /// Input: nums = [1,2,3,1]
    /// Output: true
    /// </example>
    /// <see cref="https://leetcode.com/problems/contains-duplicate/"/>
    /// <param name="nums"></param>
    /// <returns>bool</returns>
    public static bool ContainsDuplicate(int[] nums) {
        HashSet<int> looped = new HashSet<int>();
        foreach(int num in nums){
            if(looped.Contains(num)) return true;
            looped.Add(num);
        }
        return false;
    }
    
    
    /// <summary>
    /// Given a signed 32-bit integer x, return x with its digits reversed.
    /// If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
    /// Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
    /// </summary>
    /// <example>
    /// Input: x = 123
    /// Output: 321
    /// </example>
    /// <see cref="https://leetcode.com/problems/reverse-integer/"/>
    /// <param name="x"></param>
    /// <returns>bool</returns>
    public static int Reverse(int x) {
        try{
            long result = 0;
            bool isNegative = x < 0;

            long value = Math.Abs(x);
            do{
                var remainder = value % 10;
                result = 10 * result + remainder;
                value /= 10;

            }while(value > 0);

            var response = isNegative ? -1 * result: result;
            if(response < int.MinValue || response > int.MaxValue){
                return 0;
            }
            return (int)response;
        } catch (Exception ex){
            return 0;
        }
    }
}