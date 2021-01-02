using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    class Program
    {
        interface IDoor
        {

        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        static int b;
        static void Main(string[] args)
        {
            for (int i = 58 - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + b);
                b = i + b;
                if (i == 5)
                {

                    Console.WriteLine("-------------");
                }
            }
        }
    }
}
