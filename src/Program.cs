using System;
using System.Collections;

class App
{
    static readonly string fileName = "input.txt";
    static void Main()
    {
        List<List<int>> elves = new List<List<int>>();

        if (!File.Exists(fileName)) return;
        using StreamReader reader = new(fileName);
        string? line;

        List<int> elf = new List<int>();
        while ((line = reader.ReadLine()) != null)
        {

            if (!line.Equals(""))
            {
                elf.Add(int.Parse(line));
                continue;
            }
            elves.Add(elf);
            elf = new List<int>();
        }
        List<int> sums = new List<int>();
        foreach (List<int> _elf in elves)
        {
            sums.Add(_elf.Sum());
        }
        Console.WriteLine(sums.Max());
    }


}