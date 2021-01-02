using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace TimeMeasurement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch myTimer=new Stopwatch();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 8,45 };
            myTimer.Start();
            int[] array2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array2[i] = array[1];
            }


            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
            myTimer.Stop();
            Console.WriteLine("Time of loops:" +" "+myTimer.Elapsed );

            myTimer.Restart();
            array2[0]=array[0];
            array2[1]=array[1];
            array2[2]=array[2];
            array2[3]=array[3];
            array2[4]=array[4];
            array2[5]=array[5];
            array2[6]=array[6];
            array2[7]=array[7];
            array2[8]=array[8];
            array2[9]=array[9];

            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array2[2]);
            Console.WriteLine(array2[3]);
            Console.WriteLine(array2[4]);
            Console.WriteLine(array2[5]);
            Console.WriteLine(array2[6]);
            Console.WriteLine(array2[7]);
            Console.WriteLine(array2[8]);
            Console.WriteLine(array2[9]);
            myTimer.Stop();
            Console.WriteLine("Without LOops:"+myTimer.Elapsed);

        }
    }
}
