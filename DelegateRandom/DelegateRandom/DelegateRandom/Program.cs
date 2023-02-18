using System;

public class Program
{
    public delegate int IntDelegate();

    public static void Main()
    {
        IntDelegate[] delegates = new IntDelegate[5];
        Random random = new Random();

        for (int i = 0; i < delegates.Length; i++)
        {
            delegates[i] = () => random.Next(100);
        }

        double average = GetDelegateAverage(delegates);
        Console.WriteLine($"Average: {average}");
    }

    public static double GetDelegateAverage(IntDelegate[] delegates)
    {
        int sum = 0;

        foreach (IntDelegate del in delegates)
        {
            sum += del();
        }
             
        return  (double)sum / delegates.Length;
    }
}