using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        int rows = ReadInt("Enter row: ");
        int cols = ReadInt("Enter col: ");

        List<List<double>> numbers = InputMatrix(rows, cols);

        Console.WriteLine("\nThe numbers are:");
        PrintMatrix(numbers);

        double sum = ComputeSum(numbers);
        int count = rows * cols;
        double average = sum / count;

        Console.WriteLine($"\nSum: {sum:0.0}  ; Average: {average:0.0}");
    }

   
    static List<List<double>> InputMatrix(int rows, int cols)
    {
        List<List<double>> matrix = new List<List<double>>();

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"\nRow {i + 1}");
            List<double> row = new List<double>();

            for (int j = 0; j < cols; j++)
            {
                double value = ReadDouble($"Enter number{j + 1}: ");
                row.Add(value);
            }

            matrix.Add(row);
        }

        return matrix;
    }

    
    static void PrintMatrix(List<List<double>> matrix)
    {
        foreach (var row in matrix)
        {
            foreach (var val in row)
                Console.Write(val.ToString("0.0") + " ");
            Console.WriteLine();
        }
    }

 
    static double ComputeSum(List<List<double>> matrix)
    {
        double sum = 0;
        foreach (var row in matrix)
            foreach (var val in row)
                sum += val;
        return sum;
    }

    
    static int ReadInt(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    
    static double ReadDouble(string message)
    {
        Console.Write(message);
        return double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }
}
