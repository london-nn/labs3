using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(Guid("123e4567-e89b-12d3-a456-426614174000"));
    }

    public static bool Guid(string guid)
    {

        string chars = "!@#$%&*ghijklmnopqrstuvwxyzGHIJKLMNOPQRSTUVWXYZ";

        if (guid.Length == 36)
        {
            string[] guidarr = guid.Split('-');
            if (guidarr[0].Length == 8 && guidarr[1].Length == 4 && guidarr[2].Length == 4 && guidarr[3].Length == 4 && guidarr[4].Length == 12)
            {
                if (!Regex.IsMatch(guid, chars))
                {
                    return true;
                }
            }
        }

        return false;
    }
}
