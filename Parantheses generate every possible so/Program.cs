using System;
using System.Text;
class Parantheses_generate_every_possible
{
    static StringBuilder output = new StringBuilder();

    static void Main()
    {
        GenParantheses(int.Parse(Console.ReadLine()), 0, string.Empty);
        Console.Write(output);
    }

    static void GenParantheses(int opening, int closing, string innerOutput)
    {
        if (opening == 0 && closing == 0)
        {
            output.Append(innerOutput + "\n");
        }

        if (opening > 0)
        {
            //balance the paranthese that's why -1 then +1
            GenParantheses(opening - 1, closing + 1, innerOutput + '[');
        }

        if (closing > 0)
        {
            GenParantheses(opening, closing - 1, innerOutput + ']');
        }
    }
}

