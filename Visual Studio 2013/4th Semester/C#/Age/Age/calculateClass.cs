using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class calculateClass
    {

        List<int> rupees=new List<int>();
     

        public void CalculateAge(int year, int month)
        {
           // rupees.Add(2);
           // rupees.Add(4);
           // rupees.Add(66);
           // rupees.Add(7);

           //// rupees.Remove(66);
           // rupees.Insert(3, 35);
            foreach (var item in rupees)
            {
                Console.WriteLine(item);
            }
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;


            int newYear = currentYear - year;
            int newmonth = currentMonth-month;
            var m = -1;
            if (newmonth < 0)
            {
               //newmonth= 12 + newmonth;
                newmonth=m*(newmonth);
               Console.WriteLine("you will be  {0} year old after  {1} Months", newYear, newmonth);
              
                newYear--;
                newmonth = 12 - newmonth;
                Console.WriteLine("your current Age is :{0} year and {1} Months", newYear, newmonth);

            }
            else
            Console.WriteLine("The Age is :{0} year , {1} Months",newYear,newmonth);
            

        }
    }
}
