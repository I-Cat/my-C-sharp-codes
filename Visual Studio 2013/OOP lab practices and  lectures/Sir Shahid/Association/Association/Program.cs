using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student("1111", "Asif", "BSSE");
            Student std2 = new Student("12343", "Ali", "BSCS");
            Student std3 = new Student("11132", "Usama", "TTM");

            Course.noofStudents = 3;
            Course oop = new Course("CSC-1013", "Object oriented");

            oop.EnrollStudent(std1);
            oop.EnrollStudent(std2);
            oop.EnrollStudent(std3);

            oop.PrintStudent();
            //Course c = new Course("1232-2", "DB");

            //c.PrintStudent();
        }
    }
}
