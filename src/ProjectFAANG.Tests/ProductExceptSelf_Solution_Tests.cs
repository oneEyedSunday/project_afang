using Xunit;
using ProductOfArrayExceptSelf;

namespace ProjectFAANG.Tests
{
    public class ProductExceptSelfSolution_Tests
    {
        [Fact]
        public void Empty_Array_Returns_Empty_Result()
        {
            var result = new Solution().ProductExceptSelf(new int[] { });
            Assert.Empty(result);
        }

        [Theory]
        [InlineData(new int[] { 0, 0 }, new int[] { 0, 0 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int [] { 24, 12, 8, 6 })]
        public void Solution_Works_On_Inputs(int[] input, int[] expected)
        {
            var result = new Solution().ProductExceptSelf(input);
            Assert.Equal(result, expected);
        }
    }
}
