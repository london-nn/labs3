using System.Text.RegularExpressions;

class TestClass
{
    static void Main(string[] args)
    {
        string agestr = Console.ReadLine();
        int age = Convert.ToInt32(agestr);

        if(age >= 0 && age <= 12)
        {
            Console.WriteLine("ребёнок");
        }
        else if ( age >= 13 && age <= 19 )
        {
            Console.WriteLine("подросток");
        }
        else
        {
            Console.WriteLine("взрослый");
        }
    }


}
