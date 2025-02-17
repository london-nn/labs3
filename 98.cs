using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(CreditCard("4111 1111 1111 1111"));
    }

    static bool CreditCard(string number)
    {

        string[] numberarr = number.Split(' ');
        string cleannumber = number.Replace(" ", "");

        if(numberarr.Length == 4 )
        {                                                   
            if (Regex.IsMatch(cleannumber, "^[0-9]{16}$"))
            {
                return true;
            }
        }

        return false;
    }

  
}
