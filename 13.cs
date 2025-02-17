using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
       string number = Console.ReadLine();

        if (number[0].Equals('+') && number[1].Equals('7'))
        {
            string n = number.Replace("+", "");
            if (Regex.IsMatch(n, "[0-9]{11}"))
            {
                Console.WriteLine("Номер правильный");
            }
        }
        else { Console.WriteLine("Ошибка"); }
    }


}
