using System;
using System.Collections.Generic;
class Program
{

    static void Main()
    {
        var k = int.Parse(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());
        var possibleCombinations = new HashSet<int>();

        possibleCombinations.Add(0);
        var count = 0;

        for (int i = 0; i < n; i++)
        {
            var element = int.Parse(Console.ReadLine());
            var currenPossibleCombinations = new HashSet<int>();

            foreach (var combination in possibleCombinations)
            {
                currenPossibleCombinations.Add(combination + element);
            }

            foreach (var combination in currenPossibleCombinations)
            {
                possibleCombinations.Add(combination);
                if (combination >= k)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);

    }
}

