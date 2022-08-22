using FluentAssertions;

namespace algos.test;

public class AlgoTestsTest
{
    [Fact]
    public void ContainsDuplicate_ValidInput_True()
    {
        var res = AlgoTests.ContainsDuplicate(new []{1,2,3,1});
        res.Should().BeTrue();
    }
    
    [Fact]
    public void ContainsDuplicate_ValidInput_False()
    {
        var res = AlgoTests.ContainsDuplicate(new []{1,2,3,4});
        res.Should().BeFalse();
    }
    
    [Fact]
    public void ReverseNumber_ValidInput_ReverseInt()
    {
        var res = AlgoTests.Reverse(123);
        res.Should().Be(321);
    }
}