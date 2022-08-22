using FluentAssertions;
using Xunit.Abstractions;

namespace algos.test;

public class UtilitiesTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UtilitiesTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void SwapArray_ValidInput_SwapInput()
    {
        var arr = new int[]{ 5, 1, 4, 2, 8 };
        Utilities.SwapArray(arr, 0, 1);
        arr.Should().BeEquivalentTo(new int[]{ 1, 5, 4, 2, 8 });
    }
    
    [Fact]
    public void Factorial_ValidInput_GetFactorialOfANum()
    {
        var res = Utilities.Factorial(5);
        res.Should().Be(120);
    }
    
    [Fact]
    public void FactorialRecursion_ValidInput_GetFactorialOfANum()
    {
        var res = Utilities.FactorialRecursion(5);
        res.Should().Be(120);
    }
}