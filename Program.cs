using System;
using CodingProblems.Solutions;

namespace CodingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call static method for any problem
            Console.WriteLine(
                SubsetSumCount.GetCount(new int[]{1, 1, 1}, 2)
            );
        }
    }
}
