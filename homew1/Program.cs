using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("\nEnter string: ");
            string input = Console.ReadLine();

            if (input == "*")
                break;

            string reversed = ReverseString(input);
            bool isPalindrome = CheckPalindrome(input, reversed);

            DisplayResult(input, reversed, isPalindrome);
        }
    }

    static string ReverseString(string str)
    {
        string lowerStr = str.ToLower();
        char[] charArray = lowerStr.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static bool CheckPalindrome(string original, string reversed)
    {
        return original.ToLower() == reversed;
    }

    static void DisplayResult(string original, string reversed, bool isPalindrome)
    {
        Console.WriteLine("\n{0,-25}{1,-25}{2,-15}",
            "Original String", "Reversed String", "Palindrome?");

        Console.WriteLine("{0,-25}{1,-25}{2,-15}",
            original, reversed, isPalindrome ? "Yes" : "No");
    }
}
