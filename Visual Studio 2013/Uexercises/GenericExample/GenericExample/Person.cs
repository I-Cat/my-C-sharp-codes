using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class Person
    {
        string name;
        string Fname;

        public Person(string name,string Fname)
        {
            this.name = name;
            this.Fname = Fname;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", name, Fname);
        }
    }
}
