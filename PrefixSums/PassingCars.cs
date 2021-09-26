using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeLessons
{
    public class PassingCars
    {
        public int Solution(int[] A)
        {
            int pairs = 0, east = 0;
            if(A.Length > 1)
                foreach (var i in A) {
                    if (i == 0)
                        ++east;
                    else if(east > 0 && (pairs += east) > 1e9)
                        return -1;
                }
            return pairs;
        }
    }
}
