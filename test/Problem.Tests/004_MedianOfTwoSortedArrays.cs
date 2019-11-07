using Algorithms.Problem.Hard;
using Xunit;

namespace Algorithms.Problem.Tests
{
    public class _004_MedianOfTwoSortedArrays_Test
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Hard")]
        [Trait("Topic", "Array")]
        [Trait("Topic", "Binary Search")]
        [Trait("Topic", "Two Pointers")]
        [Trait("Topic", "Divide and Conquer")]
        [InlineData(new[] { 1, 3 }, new[] { 2 }, 2.0)]
        [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
        [InlineData(new[] { 2 }, new[] { -2, -1 }, -1.0)]
        public void CanFindMedianSortedArrays(int[] nums1, int[] nums2, double expected)
        {
            // Arrange
            // Act
            var result = new _004_MedianOfTwoSortedArrays().FindMedianSortedArrays(nums1, nums2);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion Public Methods
    }
}