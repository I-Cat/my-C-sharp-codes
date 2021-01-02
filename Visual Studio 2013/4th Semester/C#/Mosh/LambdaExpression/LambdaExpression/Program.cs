using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //first Example
            #region
            
            //const int Factor = 6;
            //Func<int, int> Square = num => num * Factor;
            //Console.WriteLine(Square(4));
            #endregion

          //  2nd Example List
            var book = new BooksRepository().GetBooks();
           var cheapherBooks= book.FindAll(b => b.Price >= 150);

           foreach (var item in cheapherBooks)
           {

               Console.WriteLine(item.Title);
           }
           
          


        }
    }
}
