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
            {
                Console.WriteLine("\n//End execution");
                break;
            }

            string lowerInput = input.ToLower();
            string reversed = "";

            for (int i = lowerInput.Length - 1; i >= 0; i--)
            {
                reversed += lowerInput[i];
            }

          
            string palindrome = (lowerInput == reversed) ? "Yes" : "No";

          
            Console.WriteLine("\n{0,-25}{1,-25}{2,-15}",
                "Original String", "Reversed String", "Palindrome?");

          
            Console.WriteLine("{0,-25}{1,-25}{2,-15}",
                input, reversed, palindrome);
        }
    }
}
