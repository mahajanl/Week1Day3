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

            //Console.WriteLine("How old are you?");
            //int userAge = int.Parse(Console.ReadLine());

            //if(userAge >= 0 && userAge <= 1)
            //{
            //    Console.WriteLine("You're such a wittle thing!");

            //}
            //else if(userAge > 1 && userAge < 4)
            //{
            //    Console.WriteLine("Daaaw, toddlers!");
            //}
            //else if(userAge >= 4 && userAge <13)
            //{
            //    Console.WriteLine("Childhood is awesomeness. Have fun and don't grow up too fast.");
            //}
            //else if(userAge >= 13 && userAge < 65)
            //{
            //    Console.WriteLine("Life gets awkward.");
            //}
            //else if(userAge >= 65 && userAge < 100)
            //{ Console.WriteLine("Have a great retirement.");
            //}
            //else
            //{
            //    Console.WriteLine("That is definitely not your age.");
            //}

            //Console.WriteLine("How many points have you earned?");

            //int pointsEarned = int.Parse(Console.ReadLine());

            //switch (pointsEarned)
            //{
            //    case 0:
            //        Console.WriteLine("You have no points :(");
            //        break;
            //    case 1:
            //        Console.WriteLine("You should probably practice a bit more.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Not too bad, but I think you could do better.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Nice!");
            //        break;
            //    case 4:
            //        Console.WriteLine("Way to go! I wrote this thing and I'm not that good.");
            //        break;
            //    case 5:
            //        Console.WriteLine("I think you're the new Master of the Game. I bow to you.");
            //        break;
            //}

            Console.WriteLine("How many people are in your party?");
            int people = int.Parse(Console.ReadLine());

            Console.WriteLine("How much was each person's bill?");
            int billPerPerson = int.Parse(Console.ReadLine());

            int billTotal = billPerPerson * people;
            double newBill;

            if(billTotal >= 50)
            {
                newBill = billTotal * .9;
                Console.WriteLine("The discounted total is $" + newBill);
                    }

            else
            {
                newBill = billTotal * .95;
                Console.WriteLine("The discounted total is $" + newBill);
            }


            //Console.WriteLine("The total bill for the whole party was " + "$" + billTotal);

        }
    }
}
