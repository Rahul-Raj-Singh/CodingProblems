using System;

namespace CodingProblems.Solutions
{
    /// <summary>
    /// Given an array of items with specific wts and values
    /// Find maximum profit that can be gained for given W
    ///     eg: val = [1, 3, 2], wt = [5, 5, 10], W = 10
    ///         max profit = 4
    /// </summary>
    public class KnapSack
    {
        public static int GetProfit(int[] val, int[] wt, int w)
        {
            int n = val.Length;
            int[,] dp = new int[n+1, w+1];

            for(int i=1; i<=n; i++) {
                for(int j=1; j<=w; j++) {
                    if(wt[i-1] > j)
                        dp[i, j] = dp[i-1, j];
                    else
                        dp[i,j] = Math.Max(val[i-1] + dp[i-1, j-wt[i-1]], dp[i-1, j]);
                }
            }

            return dp[n, w];

        }
    }
}