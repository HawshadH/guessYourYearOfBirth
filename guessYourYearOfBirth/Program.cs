using System;

namespace guessYourYearOfBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Your Age");
            String myAge = Console.ReadLine();
            int age = int.Parse(myAge);

            Console.WriteLine("Insert the Year");
            String year = Console.ReadLine();
            int thisYear = int.Parse(year);

            Console.WriteLine("Your year of birth is : "+ (thisYear - age));
        }
    }
}
