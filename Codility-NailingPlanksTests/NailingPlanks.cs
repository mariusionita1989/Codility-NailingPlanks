using Codility_NailingPlanks;

namespace Codility_NailingPlanksTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestExampleCase()
        {
            Solution solution = new Solution();
            int[] A = { 1, 4, 5, 8 };
            int[] B = { 4, 5, 9, 10 };
            int[] C = { 4, 6, 7, 10, 2 };
            int result = solution.solution(A, B, C);
            Assert.Equal(4, result);
        }

        [Fact]
        public void TestNoNailPossible()
        {
            Solution solution = new Solution();
            int[] A = { 1, 2, 3 };
            int[] B = { 4, 5, 6 };
            int[] C = { 7, 8, 9 };
            int result = solution.solution(A, B, C);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void TestSinglePlankAndNail()
        {
            Solution solution = new Solution();
            int[] A = { 1 };
            int[] B = { 2 };
            int[] C = { 1 };
            int result = solution.solution(A, B, C);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestAllNailsAtTheEnd()
        {
            Solution solution = new Solution();
            int[] A = { 1, 2, 3 };
            int[] B = { 4, 5, 6 };
            int[] C = { 6, 6, 6 };
            int result = solution.solution(A, B, C);
            Assert.Equal(-1, result);
        }
    }
}