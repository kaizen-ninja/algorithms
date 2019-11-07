using Algorithms.Problem.Medium;
using Xunit;

namespace Algorithms.Problem.Tests
{
    public class _079_WordSearch_Test
    {
        [Fact]
        public void ExistTest_Exist()
        {
            var input = new char[3, 4]
            {
                { 'A', 'B', 'C', 'E' },
                { 'S', 'F', 'C', 'S' },
                { 'A', 'D', 'E', 'E' }
            };

            var solution = new _079_WordSearch();
            var result = solution.Exist(input, "ABCCED");

            Assert.True(result);
        }

        [Fact]
        public void ExistTest_Exist_2()
        {
            var input = new char[3, 4]
            {
                { 'A', 'B', 'C', 'E' },
                { 'S', 'F', 'C', 'S' },
                { 'A', 'D', 'E', 'E' }
            };

            var solution = new _079_WordSearch();
            var result = solution.Exist(input, "SEE");

            Assert.True(result);
        }

        [Fact]
        public void ExistTest_NotExist()
        {
            var input = new char[3, 4]
            {
                { 'A', 'B', 'C', 'E' },
                { 'S', 'F', 'C', 'S' },
                { 'A', 'D', 'E', 'E' }
            };

            var solution = new _079_WordSearch();
            var result = solution.Exist(input, "ABCB");

            Assert.False(result);
        }
    }
}