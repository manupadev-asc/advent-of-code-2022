using System;

class App
{
    static void Main()
    {

        string[] data = File.ReadAllLines("input.txt");
        for (int i = 0; i < data.Length; i++)
        {
            Console.WriteLine(data[i]);
        }
    }
}