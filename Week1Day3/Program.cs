using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstNumber = 2;
            //int secondNumber = 6;

            //if(firstNumber > secondNumber)
            //{
            //    //if condition is true, then do something
            //    Console.WriteLine("You have broken math. Good job.");
            //}
            //else
            //{
            //    //do something else
            //    Console.WriteLine("That makes sense.");
            //}

            //Console.WriteLine("What day of the week is it?");
            //string userAnswer = Console.ReadLine();

            //if(userAnswer == "Monday")
            //{
            //    Console.WriteLine("Well that's unfortunate.");
            //}
            //else if(userAnswer == "Friday")
            //{
            //    Console.WriteLine("Happy Friday!!");
            //}
            //else
            //{
            //    Console.WriteLine("You'll get through this!");
            //}

            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());

            if(userAge <= 1)
            {
                Console.WriteLine("You're such a wittle thing!");

            }
            else if(userAge > 1 && userAge < 4)
            {
                Console.WriteLine("Daaaw, toddlers!");
            }
            else if(userAge >= 4 && userAge <13)
            {
                Console.WriteLine("Childhood is awesomeness. Have fun and don't grow up too fast.");
            }
            else if(userAge >= 13 && userAge < 65)
            {
                Console.WriteLine("Life gets awkward.");
            }
            else if(userAge >= 65 && userAge < 100)
            { Console.WriteLine("Have a great retirement.");
            }
            else
            {
                Console.WriteLine("That is definitely not your age.");
            }
        }
    }
}
