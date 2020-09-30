using System;
using System.Runtime.InteropServices.ComTypes;

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

            bool locomotivesareavalible = true ;
          

            var steamer = (locomotivesareavalible == true) ? "Yes, we have a locomotive in stock" : "No, we do not have a locomotive in stock";
            Console.WriteLine(steamer);
            var outofstock = (locomotivesareavalible != true) ? "We do not have a locomotive in stock" : "eh, sure, why not?";
            Console.WriteLine(outofstock);


            bool carsareavalible = true;
            bool classiccarsinstock = true;

            var firstsale = (carsareavalible == true) ? "Ok, so We do have some cars out back, cannot assure you in regards to classic cars, but \n We DO have some cars open for purchase." : "Sorry Sir/Ma'am, At this present moment we lack anything in stock, please return later.";
            var secondsale = (classiccarsinstock == true) ? "We even have some classics in stock today! Today is quite lucky for You!" : "Sorry, nothin's avalible in terms of classic cars.";
            Console.WriteLine("Welcome to Bryce' Automotive Emperorium, where We upkeep and maintain exotic cars from all eras, past or new.\n \nIf you are interested in buying anything from us, please type in y or n as single characters please. However,if You are interested in our vintage vehicle fleet, type in 'classic' as a whole, without capitalization.");
            string userinput = Console.ReadLine();

            if (userinput == "y")
            {
                Console.WriteLine(firstsale);
            }

            else if (userinput == "n")
            {
                Console.WriteLine("Ok then, have a nice day and thanks for wasting Our time! :D");
            }


            else if (userinput == "classic")
            {
                Console.WriteLine("Alright then, Let's see if We have anything in stock." + "\n" + secondsale );
            }

            else
            {
                Console.WriteLine("... What?.. huh?... Just.. I'm calling the police Sir/Ma'am, You aren't well.");
            }
           


        }
    }
}
