using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student
    {
        public string RegisterationNo { get; set; }
        public string Name { get; set; }
        public string Programe { get; set; }

        public Student(String registerationNo,string name,string programe)
        {
            RegisterationNo = registerationNo;
            Programe = programe;
            Name = name;

        }


        public override string ToString()
        {
            return string.Format("RegisterationNo.\t{0}\nName:\t\t\t{1}\nPrograme:\t\t{2}",RegisterationNo,Programe,Name);
         
        }
       
    }
}
