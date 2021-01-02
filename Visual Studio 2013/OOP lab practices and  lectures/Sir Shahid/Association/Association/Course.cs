using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Course
    {
        public static int noofStudents;
        public int indexNo;
        Student[] array = new Student[noofStudents];

        public string Code { get; set; }
        public string Title { get; set; }

        public Course(string code,string title)
        {
            Code = code;
            Title = title;
        }


        public void EnrollStudent(Student std)
        {
            array[indexNo] = std;
            indexNo++;
        }

        public void PrintStudent()
        {
            foreach(Student std in array)
            {
                Console.WriteLine(std);
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
