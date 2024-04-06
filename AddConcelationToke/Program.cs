using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        var che = FindMaxInArrayAsync(array);
        Console.WriteLine(che.Result);
        Thread.Sleep(6000);
        Console.WriteLine(che.Result);
    }

    private static async Task<int> FindMaxInArrayAsync(int[] array)
    {
        return await Task.Run(() => FindMaxInArray(array));
    }
    private static int FindMaxInArray(int[] array)
    {
        int max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            Thread.Sleep(1000);
        }

        return max;
    }
}