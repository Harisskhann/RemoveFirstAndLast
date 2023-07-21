using System;

public class Program
{
    public static string RemoveFirstAndLastCharacters(string inputString)
    {
        int length = inputString.Length;

        if (length <= 2)
            return "";

        string result = "";
        for (int i = 1; i < length - 1; i++)
        {
            result += inputString[i];
        }

        return result;
    }
    public static void Main()
    {
        String S = "HelloWorld";
        Console.WriteLine(RemoveFirstAndLastCharacters(S));
        Console.ReadLine();
    }
}