using System;
using System.Linq;

public static class ArrExtension
{
    public static string RandString(this string str, int c)
    {
        char[] arr = str.ToCharArray();
        Random rand = new Random();
        arr = arr.OrderBy(x => rand.Next()).ToArray();
        string finalStr = new string(arr);
        try 
        {
            finalStr = finalStr.Substring(0, c - 1);
            return finalStr;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Исключение: {ex.Message}");
            Console.WriteLine($"Метод: {ex.TargetSite}");
            Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            Console.ReadKey();
            return null;
        }
    }
}
namespace REC_129
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string beginString = Console.ReadLine();
            Console.Write("Введите длину результирующей строки: ");
            int len = int.Parse(Console.ReadLine());
            Console.Write(beginString.RandString(len));
            Console.ReadKey();
        }
    }
}
