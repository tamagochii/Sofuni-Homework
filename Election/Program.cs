using System;
using System.Collections.Generic;
using System.Numerics;

class Election
{
    static BigInteger count;
    static void Main()
    {
        var targetSum = int.Parse(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());
        var nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        GenerateWinningParties(0, 0, nums, targetSum);
        Console.WriteLine(count);     
    }

    static void GenerateWinningParties(int sum, int recDepth, int[] nums, int targetSum)
    {
        if (sum >= targetSum)
        {
            count += (BigInteger)Math.Pow(2, nums.Length - recDepth);
        }
        else
        {
            for (int i = recDepth; i < nums.Length; i++)
            {
                GenerateWinningParties(sum + nums[i], i + 1, nums, targetSum);
            }
        }

    }
}
