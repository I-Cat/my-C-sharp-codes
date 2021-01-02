using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {                    ///same can be done with for loop
       public static string text;
        static void Main(string[] args)
        {
           
            RecursiveSolution(1);
           

            
        }
        public static void RecursiveSolution(int number)
        {
            if (number > 100)
                return;
            if (number % 3 == 0 )
            {
                text = "fizz";
            }
            else if (number % 5 == 0)
            {
                text = "Buzz";
            }
            else if (number % 5 == 0 && number % 3 == 0)
            {
                text = "FizzBuzz";
            }
            else
            {
                text = number.ToString();
            }
            Console.WriteLine(text);
            RecursiveSolution(number + 1);
        }
    }
}
