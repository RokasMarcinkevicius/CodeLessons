using System;

namespace CodeLessons
{
    public class PermMissingElement
    {
        public int Solution(int[] A)
        {
		int
			l = A.Length + 1,
			expectedSum = (int)Math.Ceiling(l / 2.0) * (l + (l + 1) % 2), // yea
			sum = 0;

            for (int i = -1; ++i < A.Length;)
            {
                sum += A[i];
            }

            return expectedSum - sum;
	    }
    }
}
