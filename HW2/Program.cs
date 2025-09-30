using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Enter row: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter col: ");
        int cols = int.Parse(Console.ReadLine());

        List<List<double>> numbers = new List<List<double>>();
        double sum = 0;
        int count = 0;

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"\nRow {i + 1}");
            List<double> rowList = new List<double>();

            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter number{j + 1}: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                rowList.Add(value);
                sum += value;
                count++;
            }

            numbers.Add(rowList);
        }

        Console.WriteLine("\nThe numbers are:");
        foreach (var row in numbers)
        {
            foreach (var val in row)
            {
                Console.Write(val.ToString("0.0") + " ");  
            }
            Console.WriteLine();
        }

        double average = sum / count;
        Console.WriteLine($"\nSum: {sum:0.0}  ; Average: {average:0.0}");
    }
}
