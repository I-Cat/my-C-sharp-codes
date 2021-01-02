using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Integer i = new Integer(12,34);
            Integer j = new Integer(12, 44);
            Integer d=i+j;
            Console.WriteLine("{0} + {1} = {2}",i,j,d);
            Integer sub = i - j;
            Console.WriteLine("{0} - {1} = {2}",i,j,sub);

            Integer multi = i * j;
            Console.WriteLine("{0} - {1} = {2}", i, j, multi);

            Integer divide = i / j;

            Console.WriteLine("{0} - {1} = {2}", i, j, divide);

        }
    }
}
