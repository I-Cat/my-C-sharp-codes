using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 40;

            Console.WriteLine("Before");
            Console.WriteLine("num1 = {0}", a);
            Console.WriteLine("num1 = {0}", b);
           
            Console.WriteLine("***After swaping***");

            Swap<int>(ref a, ref b);
            
            //

             Person p=new Person("Asif", "Ali");
            Person q=new Person("Asim", "Bashir");

            Swap<Person>(ref p , ref q);
        }

        public static void Swap<T>(ref T num1, ref T num2)
        {
            T temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("num1 = {0}", num1);
            Console.WriteLine("num1 = {0}", num2);
        }
    }
}
