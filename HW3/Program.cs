using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<char, int> GetCharFrequency(string input)
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (c == ' ' || c == ',') continue;
            if (frequency.ContainsKey(c))
                frequency[c]++;
            else
                frequency[c] = 1;
        }
        return frequency;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(',');

        foreach (string part in parts)
        {
            Dictionary<char, int> result = GetCharFrequency(part.Trim());
            foreach (var kvp in result)
            {
                Console.Write(kvp.Key + "=" + kvp.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
