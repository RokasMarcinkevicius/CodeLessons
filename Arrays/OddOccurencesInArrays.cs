using System.Collections.Generic;

namespace CodeLessons
{
    public class OddOccurencesInArrays
    {
        // The outer loop picks all elements one by one and
        // the inner loop counts the number of occurrences of the element picked by the outer loop.
        // Brute Force approach - O(n^2) solution
        public int SolutionNestedArrays(int []arr, int arr_size)
        {
            for (int i = 0; i < arr_size; i++) {
                int count = 0;

                for (int j = 0; j < arr_size; j++) {
                    if (arr[i] == arr[j])
                        count++;
                }
                if (count % 2 != 0)
                    return arr[i];
            }
            return -1;
        }

        // Use array elements as a key and their counts as values.
        // Create an empty hash table.
        // One by one traverse the given array elements and store counts.
        // The time complexity of this solution is O(n).
        public int SolutionHashSet(int[] A, int arr_size)
        {
            var has = new HashSet<int>();
            foreach (var i in A)
            {
                if (has.Contains(i))
                    has.Remove(i);
                else
                    has.Add(i);
            }

            foreach(var i in has)
            {
                return i;
            }

            return 0;
	    }

        // XOR of all elements gives us odd occurring elements.
        // Please note that the XOR of two elements is 0 if both elements are the same and the XOR of a number x with 0 is x.
        // Crazy chinese solution - Time Complexity: O(n)
        public int SolutionBitwiseXOR(int []arr, int arr_size)
        {
            int res = 0;
            for (int i = 0; i < arr_size; i++)
            {
                res = res ^ arr[i]; // Might as well just use magic tbh
            }
            return res;
        }
    }
}

