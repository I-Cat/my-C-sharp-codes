using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
                var path1 = @"C:\Users\ASIF ALI\Desktop\T.txt";

            //   // FileStream f = new FileStream( path1, FileMode.OpenOrCreate,FileAccess.ReadWrite);
            //    using (StreamWriter sw = File.CreateText(path1))
            //    {
            //        sw.WriteLine("Hello Asif");
            //        sw.WriteLine("Hello Asif");
            //        sw.WriteLine("Hello Asif");
            //        sw.WriteLine("Hello Asif");
            //    }
            //   // File.SetLastWriteTime(path1, new DateTime(1985, 4, 3));

            //    using (StreamReader sr = File.OpenText(path1))
            //    {
            //        string s= "";
            //         while ((s = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(s);
            //        }
            //    }

            //    var path = @"C:\Users\ASIF ALI\Desktop\3 Days work 5-8 Apr.txt";

            //    File.WriteAllText(path, "I loved C# Hello");
            //    Console.WriteLine(File.ReadAllText(path));
            //}
            
                //for (int i = 0; i < 3; i++)
                //{
                //    Console.WriteLine("Write your text");
                //    var str = Console.ReadLine();
                //    File.AppendAllText(path1, str);
                //    //File.AppendText(path1);

                ////    File.WriteAllText(path1, str);
                //}
                File.CreateText(path1);

                Console.WriteLine( File.ReadAllText(path1));

                Process.Start(path1);
        }
    }
}
