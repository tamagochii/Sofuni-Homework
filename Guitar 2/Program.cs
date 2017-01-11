using System;
using System.Collections.Generic;
using System.Linq;
class Guitar_2
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var startingVolume = int.Parse(Console.ReadLine());
        var maxVolume = int.Parse(Console.ReadLine());

        var possibleSums = new HashSet<int>();
        possibleSums.Add(startingVolume);

        for (int i = 0; i < nums.Length; i++)
        {
            var currentPossibleSums = new HashSet<int>();

            foreach (var sum in possibleSums)
            {
                if (sum + nums[i] >= 0 && sum + nums[i] <= maxVolume)
                {
                    currentPossibleSums.Add(sum + nums[i]);
                }

                if (sum - nums[i] >= 0 && sum - nums[i] <= maxVolume)
                {
                    currentPossibleSums.Add(sum - nums[i]);
                }
            }

            possibleSums.Clear();

            foreach (var sum in currentPossibleSums)
            {
                possibleSums.Add(sum);
            }
        }

        if (possibleSums.Count == 0) //didnt add a single sum 
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(possibleSums.Max());
        }
    }
}

