using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Employee<T1,T2,T3>
    {
        //T1:empID
        //T2:deptID
        //T3:name

        private T1 empID;
        private T2 deptID;
        private T3 name;

        public T3 Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public T2 DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }
        
        public T1 EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public Employee(T1 empID,T2 deptID,T3 name)
        {
            EmpID = empID;
            DeptID = deptID;
            Name = name;

        }

        public override string ToString()
        {
            return string.Format("Employee ID:\t{0}\nDepartMent ID:\t{1}\nName:\t{2}\n---------------------\n", EmpID, DeptID, Name);
        }
    }
}
