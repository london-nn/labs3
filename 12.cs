using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
       string s = Console.ReadLine();
        s = s.ToLower();
        if (s.Equals("да"))
        {
            Console.WriteLine("YES");
        }
        else if (s.Equals("нет"))
        {
            Console.WriteLine("NO");
        }
        else { Console.WriteLine("Ошибка"); }
    }


}
