// See https://aka.ms/new-console-template for more information


public class AverageCalculator
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The array cannot be null or empty.");
        }

        int sum = 0;
        foreach (int nume in numbers)
        {
            sum += nume;
        }

        return (double)sum / numbers.Length;
    }
    public static int FindMaxValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The array is either null or empty.");
        }

        int max = numbers[0]; // Initialize max with the first element of the array

        // Iterate through the array to find the maximum value
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }
}
