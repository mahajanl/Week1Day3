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

            Console.WriteLine("What day of the week is it?");
            string userAnswer = Console.ReadLine();

            if(userAnswer == "Monday")
            {
                Console.WriteLine("Well that's unfortunate.");
            }
            else if(userAnswer == "Friday")
            {
                Console.WriteLine("Happy Friday!!");
            }
            else
            {
                Console.WriteLine("You'll get through this!");
            }
        }
    }
}
