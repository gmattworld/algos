using FluentAssertions;
using Xunit.Abstractions;

namespace algos.test;

public class SortAlgoTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public SortAlgoTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }


    [Theory]
    [InlineData(new int[]{ 78, 55, 45, 98, 13 })]
    [InlineData(new int[]{ -2, 45, 0, 11, -9 })]
    [InlineData(new int[]{ 5, 1, 4, 2, 8 })]
    public void BubbleSort_ValidInput_SortInput(int[] arr)
    {
        SortAlgorithms.BubbleSort(arr);
        _testOutputHelper.WriteLine(string.Join(", ", arr));
        arr.Should().BeInAscendingOrder();
    }
    
    [Theory]
    [InlineData(new int[]{ 78, 55, 45, 98, 13 })]
    [InlineData(new int[]{ -2, 45, 0, 11, -9 })]
    [InlineData(new int[]{ 5, 1, 4, 2, 8 })]
    public void SelectionSort_ValidInput_SortInput(int[] arr)
    {
        SortAlgorithms.SelectionSort(arr);
        _testOutputHelper.WriteLine(string.Join(", ", arr));
        arr.Should().BeInAscendingOrder();
    }
    
    [Theory]
    [InlineData(new int[]{ 78, 55, 45, 98, 13 })]
    [InlineData(new int[]{ -2, 45, 0, 11, -9 })]
    [InlineData(new int[]{ 5, 1, 4, 2, 8 })]
    public void InsertionSort_ValidInput_SortInput(int[] arr)
    {
        SortAlgorithms.InsertionSort(arr);
        _testOutputHelper.WriteLine(string.Join(", ", arr));
        arr.Should().BeInAscendingOrder();
    }
    
    
    [Theory]
    [InlineData(new int[]{ 78, 55, 45, 98, 13 })]
    [InlineData(new int[]{ -2, 45, 0, 11, -9 })]
    [InlineData(new int[]{ 5, 1, 4, 2, 8 })]
    public void ShellSort_ValidInput_SortInput(int[] arr)
    {
        SortAlgorithms.ShellSort(arr);
        _testOutputHelper.WriteLine(string.Join(", ", arr));
        arr.Should().BeInAscendingOrder();
    }
    
    [Theory]
    [InlineData(new int[]{ 78, 55, 45, 98, 13 })]
    [InlineData(new int[]{ -2, 45, 0, 11, -9 })]
    [InlineData(new int[]{ 5, 1, 4, 2, 8 })]
    public void MergeSort_ValidInput_SortInput(int[] arr)
    {
        SortAlgorithms.MergeSort(arr);
        _testOutputHelper.WriteLine(string.Join(", ", arr));
        arr.Should().BeInAscendingOrder();
    }
    
    [Theory]
    [InlineData(new int[]{ 78, 55, 45, 98, 13 })]
    [InlineData(new int[]{ -2, 45, 0, 11, -9 })]
    [InlineData(new int[]{ 5, 1, 4, 2, 8 })]
    public void QuickSort_ValidInput_SortInput(int[] arr)
    {
        SortAlgorithms.QuickSort(arr);
        _testOutputHelper.WriteLine(string.Join(", ", arr));
        arr.Should().BeInAscendingOrder();
    }
}