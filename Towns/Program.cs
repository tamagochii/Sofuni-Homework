using System;
class Program
{
    static Town[] towns;

    static int[] lenIncreasing;
    static int[] lenDecreasing;

    static void Main()
    {
        Initialization();
        GetLis();
        GetLds();
        GetSumOfLisAndLds();
    }

    static void GetLds()
    {
        for (int outer = lenDecreasing.Length - 2; outer >= 0; outer--)
        {
            lenDecreasing[outer] = 1;

            for (int inner = lenDecreasing.Length - 1; inner > outer; inner--)
            {
                if (towns[outer].Citizens >= towns[inner].Citizens && lenDecreasing[outer] <= lenDecreasing[inner])
                {
                    lenDecreasing[outer] = lenDecreasing[inner] + 1;
                }
            }
        }
    }

    static void GetSumOfLisAndLds()
    {
        var maxPath = 0;

        for (int i = 0; i < lenIncreasing.Length; i++)
        {
            maxPath = Math.Max(lenDecreasing[i] + lenIncreasing[i] - 1, maxPath);
        }

        Console.WriteLine(maxPath);
    }

    static void GetLis()
    {
        for (int outer = 0; outer < towns.Length; outer++)
        {
            lenIncreasing[outer] = 1;

            for (int inner = 0; inner < outer; inner++)
            {
                if (lenIncreasing[inner] + 1 > lenIncreasing[outer] && towns[inner].Citizens < towns[outer].Citizens)
                {
                    lenIncreasing[outer] = lenIncreasing[inner] + 1;
                }
            }
        }
    }

    static void Initialization()
    {
        var n = int.Parse(Console.ReadLine());

        towns = new Town[n];
        lenIncreasing = new int[n];
        lenDecreasing = new int[n];

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(' ');
            towns[i] = new Town(input[1], int.Parse(input[0]));
        }
    }
}
class Town
{
    public string Name;
    public int Citizens;

    public Town(string Name, int Citizens)
    {
        this.Name = Name;
        this.Citizens = Citizens;
    }
}


