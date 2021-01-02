using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {

        public static void swap<T>(ref T str,ref T str1)
        {

        }
        static void Main(string[] args)
        {
           Employee<int,int,string> emp1=new Employee<int,int,string>(100,200,"Ali");
            Employee<string,string,string> emp2=new Employee<string,string,string>("NTU-1111","CS100","Waqar Ahmad");
             
           System.Console.WriteLine(emp1);
            System.Console.WriteLine(emp2);
            
        }
    }
}
