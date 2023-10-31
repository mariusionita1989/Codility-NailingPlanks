using System.Runtime.CompilerServices;

namespace Codility_NailingPlanks
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 30000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A, int[] B, int[] C)
        {
            int minNail = 1;
            int maxNail = 2 * C.Length;
            int result = -1;
            int N = A.Length;
            int M = C.Length;
            int P = B.Length;

            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE &&
               P >= RANGE_LOWEST_VALUE && P <= RANGE_HIGHEST_VALUE &&
               M >= RANGE_LOWEST_VALUE && M <= RANGE_HIGHEST_VALUE) 
            {
                while (minNail <= maxNail)
                {
                    int midNail = (minNail + maxNail) / 2;
                    if (canNailAllPlanks(A, B, C, midNail))
                    {
                        result = midNail;
                        maxNail = midNail - 1;
                    }
                    else
                        minNail = midNail + 1;
                }
            }
            
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private bool canNailAllPlanks(int[] A, int[] B, int[] C, int nails)
        {
            int maxNailPosition = 2 * C.Max();
            int[] nailsUsed = new int[maxNailPosition + 1];

            for (int i = 0; i < nails && i < C.Length; i++)
                nailsUsed[C[i]] = 1;

            for (int i = 1; i < nailsUsed.Length; i++)
                nailsUsed[i] += nailsUsed[i - 1];

            for (int i = 0; i < A.Length; i++)
            {
                int start = A[i];
                int end = B[i];

                if (end > maxNailPosition || nailsUsed[end] - (start > 0 ? nailsUsed[start - 1] : 0) == 0)
                    return false;
            }

            return true;
        }

    }
}
