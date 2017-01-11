using System;
using System.Text;

class PermutationsGeneratorWithReps
{
    static StringBuilder output = new StringBuilder();

    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            GenParantheses(i, 0, 0, string.Empty);
        }

        Console.Write(output);
    }

    static void GenParantheses(int n, int open, int ending, string innerOutput)
    {
        if (open == n && ending == n)
        {
            output.Append(innerOutput + '\n');
        }
        else if (open < n)
        {
            GenParantheses(n, open + 1, ending, innerOutput + '(');
        }
        else
        {
            GenParantheses(n, open, ending + 1, innerOutput + ')');
        }
    }
}
