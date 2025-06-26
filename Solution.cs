namespace Solution;

public class Solution
{
    // task 1
    public static (int?, int?) FindMaxValueAndSum(string str)
    {
        int? sum = null;
        int? maxVal = null;

        foreach (var character in str)
        {
            if (char.IsDigit(character))
            {
                int val = character - '0';
                sum = sum is null ? val : sum + val;
                maxVal = maxVal is null || maxVal < val ? val : maxVal;
            }
        }

        return (sum, maxVal);
    }

    // task 2
    public static int? FindIndexOfMaxVal(string str)
    {
        str = str.TrimStart();

        int? maxVal = null;
        int? index = null;

        for (var i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]) && (maxVal is null || maxVal < str[i] - '0'))
            {
                maxVal = str[i] - '0';
                index = i;
            }
        }

        return index + 1;
    }

    // task 3
    public static int FindThickestBook(int[] pagesCount)
    {
        if (pagesCount.Length == 0) throw new ArgumentException("Array should not be empty");
        return pagesCount.Max();
    }

    // task 4 
    public static (int, int?) FindFastestCars(decimal[] carSpeeds)
    {
        if (carSpeeds.Length == 0) throw new ArgumentException("Array should not be empty");

        var maxSpeed = carSpeeds.Max();
        var FirstElem = Array.IndexOf(carSpeeds, maxSpeed) + 1;
        var SecondElem = Array.LastIndexOf(carSpeeds, maxSpeed) + 1;

        return SecondElem == FirstElem ? (FirstElem, null) : (FirstElem, SecondElem);
    }
}
