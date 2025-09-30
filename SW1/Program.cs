using System;

class Program
{
   
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }


    static (double peso, double yen) ConvertCurrency(double dollar)
    {
        double peso = dollar * 57.17;
        double yen = dollar * 146.67;
        return (peso, yen);
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine();
        for (int i = 0; i < numbers.Length; i++)
        {
            int num = int.Parse(numbers[i]);
            string result = IsPrime(num) ? "Prime" : "Composite";
            Console.WriteLine($"{i + 1}.  {num,-5}   {result}");
        }

        Console.Write("\nEnter currency in ($): ");
        string currencyInput = Console.ReadLine().Replace(",", "");
        double dollar = double.Parse(currencyInput);

        var (peso, yen) = ConvertCurrency(dollar);

        Console.WriteLine("\n{0,-12}{1,-18}{2}", "Dollar($)", "Phil Peso(P)", "Jpn Yen(Y)");
        Console.WriteLine("{0,-12:N0}{1,-18:N0}{2:N0}", dollar, peso, yen);
    }
}
