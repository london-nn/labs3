using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        var a = Console.ReadLine();
        if (Regex.IsMatch(a, "[0-9]"))
        {
            Console.WriteLine("Число");
        }
        else { Console.WriteLine("не число"); }
        
    }

    
}
