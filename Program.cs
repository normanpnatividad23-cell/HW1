using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<char, int> CharFreq(string str)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        foreach (char ch in str)
        {
            if (ch == ' ' || ch == ',') continue;
            if (freq.ContainsKey(ch))
                freq[ch]++;
            else
                freq[ch] = 1;
        }
        return freq;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();
        string[] words = input.Split(',');

        foreach (string word in words)
        {
            Dictionary<char, int> freq = CharFreq(word.Trim());
            int count = 0;
            foreach (var kv in freq)
            {
                Console.Write(kv.Key + "=" + kv.Value);
                count++;
                if (count < freq.Count) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
