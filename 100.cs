using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(XML("<tag></tag>"));
    }

    static bool XML(string xml)
    {
        if (xml.Contains("<"))
        {
            if (xml.Contains(">"))
            {
                if (xml.Contains("</"))
                {
                    if (xml.Contains(">"))
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }
}
