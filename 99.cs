using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(UUID("550e8400-e29b-41d4-a716-446655440000"));
    }

    static bool UUID(string uuid)
    {

        string[] uuidarr = uuid.Split('-');
        string cleanuuid = uuid.Replace("-", "");

        if ( uuidarr.Length == 5 )
        {
            if (uuidarr[0].Length == 8 && uuidarr[1].Length == 4 && uuidarr[2].Length == 4 && uuidarr[3].Length == 4 && uuidarr[4].Length == 12)
            {
                if (Regex.IsMatch(cleanuuid, "^[0-9a-fA-F]{32}"))
                {
                    return true;
                }
            }
        }

        return false;
    }

}
