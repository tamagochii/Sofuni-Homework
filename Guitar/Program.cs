using System;
using System.Collections.Generic;
using System.Linq;
class Guitar
{
    static void Main()
    {
        var intervals = Console.ReadLine()
                               .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

        var guitarVolume = int.Parse(Console.ReadLine());

        var maxGuitarVolume = int.Parse(Console.ReadLine());


        var possibleVolumes = new HashSet<int>();

        possibleVolumes.Add(guitarVolume);

        for (int i = 0; i < intervals.Length; i++)
        {
            var currentPossibleSums = new HashSet<int>();

            foreach (var sum in possibleVolumes)
            {
                if (sum + intervals[i] >= 0 && sum + intervals[i] <= maxGuitarVolume)
                {
                    currentPossibleSums.Add(sum + intervals[i]);
                }

                if (sum - intervals[i] >= 0 && sum - intervals[i] <= maxGuitarVolume)
                {
                    currentPossibleSums.Add(sum - intervals[i]);
                }
            }

            possibleVolumes = new HashSet<int>();

            foreach (var sum in currentPossibleSums)
            {
                possibleVolumes.Add(sum);
            }
        }

        if (possibleVolumes.Count != 0)
        {
            Console.WriteLine(possibleVolumes.Max());
        }
        else
        {
            Console.WriteLine(-1);
        }
    }
}

