using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeLessons
{
    public class MissingInteger
    {
        public int Solution(int[] A)
        {
                int min = 1;
                HashSet<int> numbers = new HashSet<int>();
                foreach (int n in A) {
                    if (!numbers.Contains(n)) {
                        numbers.Add(n);
                        if (n == min)
                            while (numbers.Contains(++min));
                    }
                }
                return min;
            }
    }
}
