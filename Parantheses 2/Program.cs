using System;
using System.Text;

class Parantheses_2
{
    static StringBuilder output = new StringBuilder();

    static void Main()
    {
        GenerateParantheses(int.Parse(Console.ReadLine()), 0, string.Empty);
        Console.Write(output);
    }

    static void GenerateParantheses(int closing, int opening, string temp)
    {
        if (opening == 0 && closing == 0)
        {
            output.AppendLine(temp);
        }

        if (closing > 0)
        {
            GenerateParantheses(closing - 1, opening + 1, temp + '(');
        }

        if (opening > 0)
        {
            GenerateParantheses(closing, opening - 1, temp + ')');
        }
    }
}
