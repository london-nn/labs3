using System.Text.RegularExpressions;
using System;
using System.Diagnostics;

class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(ISBN("0-306-40615-7"));
        Console.WriteLine(ISBN("973-0-306-40615-7"));
    }

    public static bool ISBN(string isbn)
    {
        string cleanisbn = isbn.Replace("-", "");
        if (cleanisbn.Length == 10)
        {
            return ISBN10(cleanisbn, isbn);
        }
        else if (cleanisbn.Length == 13)
        {
            return ISBN13(cleanisbn, isbn);
        }

        return false;
    }

    public static bool ISBN10(string cleanisbn, string isbn)
    {

        if (!Regex.IsMatch(cleanisbn, "^[0-9]{10}$"))
            return false;

        string[] isbnarr = isbn.Split('-');
        if (isbnarr[0].Length == 1 && isbnarr[1].Length == 3 && isbnarr[2].Length == 5 && isbnarr[3].Length == 1)
        Console.WriteLine("ISBN-10");
        return true;
    }

    public static bool ISBN13(string cleanisbn, string isbn)
    {
        if (!Regex.IsMatch(cleanisbn, "^[0-9]{13}$"))
            return false;

        string[] isbnarr = isbn.Split('-');
        if (isbnarr[0].Length == 3 && isbnarr[1].Length == 1 && isbnarr[2].Length == 3 && isbnarr[3].Length == 5 && isbnarr[4].Length == 1)
        Console.WriteLine("ISBN-13");
        return true;
    }
}
