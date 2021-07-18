namespace CodingProblems.Solutions
{
    /// <summary>
    /// Given an array of non-negative integers, and a value sum, determine if there is a subset of the given set with sum equal to given sum.
    /// N = 6
    /// arr[] = {3, 34, 4, 12, 5, 2}
    /// sum = 9
    /// Output: 1
    /// </summary>
    public class SubsetSum
    {
        public static bool IsSubsetPresent(int[] a, int s)
        {
            int n = a.Length;
            bool[,] dp = new bool[n+1, s+1];

            // Base Condition: If s = 0, subset is always present with no element
            for(int i=0; i<=n; i++)
                dp[i,0] = true;

            for(int i=1; i<=n; i++) {
                for(int j=1; j<=s; j++) {
                    if(a[i-1] > j)
                        dp[i, j] = dp[i-1, j];
                    else
                        dp[i,j] = dp[i-1, j-a[i-1]] || dp[i-1, j];
                }
            }

            return dp[n, s];

        }
    }
}