using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var age = new calculateClass();

            Console.WriteLine("enter your Birth year:");
            var year=int.Parse( Console.ReadLine());
            Console.WriteLine("enter your Birth Month:");
            var month = int.Parse(Console.ReadLine());
           
            age.CalculateAge(year, month);
        }
    }
}
