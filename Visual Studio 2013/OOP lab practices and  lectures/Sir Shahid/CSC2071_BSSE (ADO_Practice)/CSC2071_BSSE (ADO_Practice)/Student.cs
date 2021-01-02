using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC2071_BSSE__ADO_Practice_
{
    class Student
    {
        public string RegistrationNo { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }

        public Student(string registrationNo)
        {
            RegistrationNo = registrationNo;
        }
        public Student(string registrationNo, string name, string fatherName)
        {
            RegistrationNo = registrationNo;
            Name = name;
            FatherName = fatherName;
        }
    }
}
