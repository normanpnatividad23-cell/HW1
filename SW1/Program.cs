using System;

class Program
{
    static bool IsPrime(int value)
    {
        if (value <= 1) return false;
        for (int divisor = 2; divisor <= Math.Sqrt(value); divisor++)
        {
            if (value % divisor == 0) return false;
        }
        return true;
    }

    static void CheckNumbers(string numberList)
    {
        string[] items = numberList.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine();
        for (int index = 0; index < items.Length; index++)
        {
            int currentNumber = int.Parse(items[index]);
            string type = IsPrime(currentNumber) ? "Prime" : "Composite";
            Console.WriteLine($"{index + 1}.  {currentNumber,-5}   {type}");
        }
    }

    static (double pesoValue, double yenValue) ConvertCurrency(double dollarValue)
    {
        double pesoValue = dollarValue * 57.17;
        double yenValue = dollarValue * 146.67;
        return (pesoValue, yenValue);
    }

    static void ShowCurrencyConversion(double dollarValue)
    {
        var (pesoValue, yenValue) = ConvertCurrency(dollarValue);

        Console.WriteLine("\n{0,-12}{1,-18}{2}", "Dollar($)", "Phil Peso(P)", "Jpn Yen(Y)");
        Console.WriteLine("{0,-12:N0}{1,-18:N0}{2:N0}", dollarValue, pesoValue, yenValue);
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string numberList = Console.ReadLine();
        CheckNumbers(numberList);

        Console.Write("\nEnter currency in ($): ");
        string userInput = Console.ReadLine().Replace(",", "");
        double dollarValue = double.Parse(userInput);
        ShowCurrencyConversion(dollarValue);
    }
}
