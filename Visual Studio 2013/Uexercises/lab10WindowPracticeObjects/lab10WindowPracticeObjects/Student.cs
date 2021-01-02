using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10WindowPracticeObjects
{
    class Student
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Location { get; set; }

        public Student(string reg)
        {
            RegNo = reg;
        }
        public Student(string name,string regno,string location)
        {
            Name = name;
            RegNo = regno;
            Location = location;
        }
    }
}
