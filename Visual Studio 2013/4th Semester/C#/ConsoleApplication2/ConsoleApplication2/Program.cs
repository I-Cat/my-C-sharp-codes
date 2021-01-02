using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays
            int[] array = new int[12];
            string[] str = { "fdsf", "hello" };
            int[,] array1=new int[3,3];
            var length = 3;

          /*  for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.WriteLine("Enter in:");
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    
                   Console.Write(array1[i,j]+" ");
                }
                Console.WriteLine();

            }*/

            //jagged arry

            int[][] jagged = new int[3][]; 
            int i; 
            jagged[0] = new int[4]; 
            jagged[1] = new int[3]; 
            jagged[2] = new int[5];
// Store values in first array
            for(i=0; i<4; i++) 
            {
                jagged[0][i] = i; 
            } 
            // Store values in second array 
            for(i=0; i<3; i++) {
                jagged[1][i] = i; 
            } 
            // Store values in third array 
            for(i=0; i<5; i++) 
            { 
                jagged[2][i] = i;
            }

// Display values in first array 
            for(i=0; i<4; i++) 
                Console.Write(jagged[0][i] + "\t");
            Console.WriteLine();
// Display values in second array 
            for(i=0; i<3; i++) 
               Console.Write(jagged[1][i] + "\t");
            Console.WriteLine();
// Display values in third array
            for(i=0; i<5; i++) 
                Console.Write(jagged[2][i] + "\t");
            Console.WriteLine();
}


        }
    }

