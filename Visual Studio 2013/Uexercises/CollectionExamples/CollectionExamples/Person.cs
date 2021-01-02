using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{
    class Person
    {
        private string firstName;
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public Person(string fname,string lname)
        {
            FirstName = fname;
            LastName = lname;
        }

        public override string ToString()
        {
            return string.Format("First name:{0}\nLast Name:{1}", firstName, lastName);
        }
    }
}
