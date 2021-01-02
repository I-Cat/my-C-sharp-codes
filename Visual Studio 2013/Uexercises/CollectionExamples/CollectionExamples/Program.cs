using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{
    
    class Program
    {
        static void Main(string[] args)
        {

            //******ArrayList****///
            ArrayList al = new ArrayList();
            al.Add(123);
            al.Add("Hello ArrayList...");
            al.Add(12.34);
            al.Add(new Person("Asif", "Ali"));
            al.Remove(12.34);
            al.Reverse()
; foreach (object obj in al)
            {
                Console.WriteLine(obj);
            }


            //****List****///
            Console.WriteLine();
            Console.WriteLine("****List******");
            Console.WriteLine();

            List<string> language = new List<string>();
            language.Add("C#");
            language.Add("C++");
            language.Add("Python");
            language.Add("AI");
            language.Insert(1, "KPK");
            Console.WriteLine("****List Before*****");
            //language.Reverse();
            foreach (string lang in language)
            {
                Console.WriteLine(lang);
            }

            Console.WriteLine("****After***");
            Console.WriteLine();

          //  bool chk=language.Remove("C#");
          //  Console.WriteLine(chk);
            //insert Method Insert new item but not Remove Already existing 
           
            language.Insert(1, "PHP");

            foreach (string lang in language)
            {
                Console.WriteLine(lang);
            }


            Console.WriteLine("\n***Stack*****\n");

            Stack<String> stk = new Stack<string>();
            stk.Push("100");
            stk.Push("200");
            stk.Push("300");
            stk.Push("400");

            foreach (string st in stk)
            {
                Console.WriteLine(st);
            }
            //peek tell uper element
            Console.WriteLine("Peek -> {0}",stk.Peek());
            Console.WriteLine("\n****After Pop() Method*****\n");
            //Remove the last item addeed
            stk.Pop();
            stk.Pop();

            foreach (string st in stk)
            {
                Console.WriteLine(st);
            }

            //*******Queue*********
            Console.WriteLine("\n****Queue*****\n");

            Queue<String> msg = new Queue<string>();
            msg.Enqueue("1st Msg");
            msg.Enqueue("2nd Msg");
            msg.Enqueue("3rd Msg");
            msg.Enqueue("4th Msg");

            foreach (string item in msg)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n****After Queue remove first 2 items*****\n");
            msg.Dequeue();
            msg.Dequeue();
            foreach (string item in msg)
            {
                Console.WriteLine(item);
            }

            ////msg.TrimExcess();
            //Console.WriteLine("\nTrimExcess()\n");
            //foreach (string item in msg)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
