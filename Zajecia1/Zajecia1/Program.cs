// See https://aka.ms/new-console-template for more information



public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Zmiana1");
        Console.WriteLine("Zmiana2");
    }


    public static double Avg(int[] arr)
    {
        int sum = 0;
        for (var i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine(sum/arr.Length);
        double result = sum / arr.Length;
        return result;
    }
}