namespace Program;

using Solution;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Task1 answer: " + Solution.FindMaxValueAndSumFromString("gsfa01we14weh6ewtr5 1ger8ewrt7 ggef"));
        Console.WriteLine("Task2 answer: " + Solution.FindIndexOfMaxVal(" dg9fgsf67sghgh268jfgh3"));
        Console.WriteLine("Task3 answer: " + Solution.FindThickestBook([34,8, 34,45, 85,76,13]));
        Console.WriteLine("Task4 answer: " + Solution.FindFastestCars([67,87,14,90]));
    }
}