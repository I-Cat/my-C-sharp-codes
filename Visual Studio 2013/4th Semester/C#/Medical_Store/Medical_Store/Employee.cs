using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Medical_Store
{
    class Employee
    {

        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhone { get; set; }
        public string Qualification { get; set; }
        public string EmployeeAdress { get; set; }
        public string EmployeeAccountType { get; set; }
        public int EmployeeSalary { get; set; }
        public DateTime EmployeeJoinDate { get; set; }



        public Employee(string name,string phone,string qualification,string address,string accountType,int salary,DateTime joinDate)
        {
            EmployeeName = name;
            EmployeePhone = phone;
            Qualification = qualification;
            EmployeeAdress = address;
            EmployeeAccountType = accountType;
            EmployeeSalary = salary;
            EmployeeJoinDate = joinDate;
        }


        public static int AddEmployeeRecord(Employee employee)
        {
            string addQuerry = "Insert into Employee values(@Name,@Phone,@Qualification,@EmpAddress,@AcountType,@Salary,@JoinDate)";
            SqlConnection conn = ConnectionManager.GetConnection();
            SqlCommand cmd = new SqlCommand(addQuerry, conn);
            cmd.CommandType = CommandType.Text;

          //  cmd.Parameters.AddWithValue("@employeeID", employee.EmployeeID);
            cmd.Parameters.AddWithValue("@Name", employee.EmployeeName);
            cmd.Parameters.AddWithValue("@Phone", employee.EmployeePhone);
            cmd.Parameters.AddWithValue("@Qualification", employee.Qualification);
            cmd.Parameters.AddWithValue("@EmpAddress", employee.EmployeeAdress);
            cmd.Parameters.AddWithValue("@AcountType", employee.EmployeeAccountType);
            cmd.Parameters.AddWithValue("@Salary", employee.EmployeeSalary);
            cmd.Parameters.AddWithValue("@JoinDate", employee.EmployeeJoinDate.ToShortDateString());

            return cmd.ExecuteNonQuery();//return the number of rows effected


        }
        public static int DeleteEmployeeRecord(int id)
        {
            string deleteQuerry = "delete from Employee where employeeID=@oldid";
            SqlConnection conn = ConnectionManager.GetConnection();
            SqlCommand cmd = new SqlCommand(deleteQuerry,conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@oldid", id);
          //  cmd.Parameters.AddWithValue("@oldid", id);

            return cmd.ExecuteNonQuery();//return the number of rows effected


        }
    }

}