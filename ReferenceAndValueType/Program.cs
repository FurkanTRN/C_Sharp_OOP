using System;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30; // değişmez çünkü değer tipli
            Console.WriteLine(number2);

            string[] cities1 = new string[] { "ankara", "adana", "afyon" };
            string[] cities2 = new string[] { "mersin", "antep", "elazığ" };

            cities2 = cities1;
            cities1[0] = "van"; // artık değişir çünkü referans tipli

            Console.WriteLine(cities2[0]);




            Console.ReadLine();
        }
    }
}
