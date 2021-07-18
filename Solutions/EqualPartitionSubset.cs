using System.Linq;

namespace CodingProblems.Solutions
{
    /// <summary>
    /// Given an array arr[] of size N, check if it can be partitioned into two parts such that the sum of elements in both parts is the same.
    /// Input: N = 4
    /// arr = {1, 5, 11, 5}
    /// Output: True
    /// </summary>
    public class EqualPartitionSubset
    {
        public static bool IsPossible(int[] a)
        {
            int sum = a.Sum();

            if(sum % 2 != 0) return false;

            return SubsetSum.IsSubsetPresent(a, sum/2);
        }
    }
}