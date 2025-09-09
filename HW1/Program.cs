using System;
using System.Collections.Generic;

class PalindromeChecker
{
    static void Main()
    {
        List<string> originalList = new List<string>();
        List<string> reversedList = new List<string>();
        List<string> resultList = new List<string>();

        while (true)
        {
            Console.Write("\nEnter string: ");
            string input = Console.ReadLine();

            if (input == "*")
            {
                break; 
            }

            string lowerInput = input.ToLower();

            string reversed = "";
            for (int i = lowerInput.Length - 1; i >= 0; i--)
            {
                reversed += lowerInput[i];
            }

            bool isPalindrome = (lowerInput == reversed);

            originalList.Add(input);
            reversedList.Add(reversed);
            resultList.Add(isPalindrome ? "Yes" : "No");
        }

        Console.WriteLine();
        Console.WriteLine("{0,-20} {1,-20} {2,-12}", "Original String", "Reversed String", "Palindrome?");
        for (int i = 0; i < originalList.Count; i++)
        {
            Console.WriteLine("{0,-20} {1,-20} {2,-12}",
                originalList[i], reversedList[i], resultList[i]);
        }

        
    }
}
