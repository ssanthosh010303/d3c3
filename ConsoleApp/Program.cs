/*
 * Author: Sakthi (Sandy) Santhosh
 * Created on: 11/04/2024
 *
 * Day-3 Challenge-3: Average of Numbers Divisible by 7
 */
namespace Challenge3;

class Program
{
    static void Main()
    {
        const int Divisor = 7;
        float total = 0f;
        int count = 0;

        float number;
        string? inputData;

        Console.Write("Enter number(s): ");
        inputData = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(inputData)) return;

        foreach (string numberString in inputData.Split(' '))
        {
            number = float.Parse(numberString);
            if (number % Divisor == 0)
            {
                total += number;
                count++;
            }
        }

        if (count == 0) return;

        Console.WriteLine("\nResult");
        Console.WriteLine("  Average: " + total / count);
    }
}
