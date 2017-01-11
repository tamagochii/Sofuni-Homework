using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Shortest_Path
{
    static void Main()
    {
        var paths = new HashSet<string>();

        var input = Console.ReadLine();
        var gaps = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '*')
                gaps.Add(i);
        }

        paths.Add(input);

        var gapIndex = 0;
        var startSwapIndex = 0;

        while (true)
        {
            if (gapIndex < gaps.Count)
            {
                startSwapIndex = gaps[gapIndex];
            }
            else
            {
                break;
            }

            var currentPossiblePaths = new HashSet<string>();
            foreach (var path in paths)
            {
                var pathArr = path.ToCharArray();
                pathArr[startSwapIndex] = 'L';

                currentPossiblePaths.Add(new string(pathArr));
                pathArr[startSwapIndex] = 'R';

                currentPossiblePaths.Add(new string(pathArr));
                pathArr[startSwapIndex] = 'S';
                currentPossiblePaths.Add(new string(pathArr));
            }

            paths.Clear();

            foreach (var path in currentPossiblePaths)
            {
                paths.Add(path);
            }

            gapIndex++;
        }

        Console.WriteLine(paths.Count);
        Console.WriteLine(string.Join("\n", paths.OrderBy(x => x).ToArray()));
   }
}

