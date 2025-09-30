using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<char, int> CountChars(string text)
    {
        var map = new Dictionary<char, int>();
        foreach (char c in text.Replace(" ", "").Replace(",", ""))
        {
            if (map.ContainsKey(c))
                map[c]++;
            else
                map[c] = 1;
        }
        return map;
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string line = Console.ReadLine();
        string[] items = line.Split(',');

        foreach (string item in items)
        {
            var result = CountChars(item.Trim());
            int i = 0;
            foreach (var pair in result)
            {
                Console.Write(pair.Key + "=" + pair.Value);
                if (++i < result.Count) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
