using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        string password = Console.ReadLine();
        if(password.Length < 8)
        {
            Console.WriteLine("Минимальное количество символов: 8");
        }
        else
        {
            Console.WriteLine("Пароль подходит");
        }
    }


}
