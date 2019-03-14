using System;
using Xunit;
using FsCheck;
using FsCheck.Xunit;

namespace PropertyBasedTestingCsharp.Tests
{
    public class AbsTests
    {
        [Theory]
        [InlineData(-100, 100)]
        [InlineData(-24, 24)]
        [InlineData(-3, 3)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(58, 58)]
        [InlineData(78, 78)]
        [InlineData(100, 100)]
        public void CanCalculateAbs(int input, int expected) 
        {
            var abs = Math.Abs(input);
            Assert.Equal(expected,abs);
        }

        [Property]
        public Property Abs_after_Abs_is_Abs(int x)
        {
            return (Math.Abs(Math.Abs(x)) == Math.Abs(x)).ToProperty();
        }

        [Property]
        public Property Abs_of_negation_is_Abs(int x)
        {
            return (Math.Abs(-x) == Math.Abs(x)).ToProperty();
        }

        [Property]
        public Property Abs_is_distributive_under_addition(int x, int y)
        {
            return (Math.Abs(x) + Math.Abs(y) == Math.Abs(x + y)).ToProperty();
        }

    }
}




