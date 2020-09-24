using System;

namespace TernaryOperatorPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

             a = 25;
            b = 30;

            int test = (a > b) ? a : b;
            Console.WriteLine("Ok, s the greatest number here is: \n  " + test);
            string test2 = (a == 10) ? "Hello":"Goodbye";
            Console.WriteLine(test2);


        }
    }
}
