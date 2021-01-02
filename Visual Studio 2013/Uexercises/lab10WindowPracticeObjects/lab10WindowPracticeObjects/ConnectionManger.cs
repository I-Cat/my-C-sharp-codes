using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace lab10WindowPracticeObjects
{
    class ConnectionManger
    {
        public static SqlConnection Getconnection()
        {
            string str = @"Data Source=ASIF\SQLEXPRESS;Initial Catalog=Student;Integrated Security=true;";

            SqlConnection connection = new SqlConnection(str);

            try
            {
                connection.Open();

            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.ToString());

            }
            return connection;
        }
        public static DataSet GetAllRecord()
        {
            string str = "select * from Stu";
            SqlConnection con = Getconnection();
            SqlCommand command = new SqlCommand(str, con);
            command.CommandType = CommandType.Text;
            DataSet ds = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds, "std");
            return ds;
        }

        public static int AddStudent(Student std)
        {

            string str = "insert into Stu values(@Name,@RegistrationNo,@Location)";
            SqlConnection con = Getconnection();
            SqlCommand command = new SqlCommand(str, con);
            command.CommandType = CommandType.Text;

            command.Parameters.Add("@Name", std.Name);
            command.Parameters.Add("@RegistrationNo",std.RegNo);
            command.Parameters.Add("@Location", std.Location);

            return command.ExecuteNonQuery();


        }

        public static int DeleteStudent(Student std)
        {

            string str = "delete from Stu where RegistrationNo=@RegistrationNo";
            SqlConnection con = Getconnection();
            SqlCommand command = new SqlCommand(str, con);
            command.CommandType = CommandType.Text;

            //command.Parameters.Add("@RegistrationNo", std.RegNo);
            command.Parameters.AddWithValue("@RegistrationNo", std.RegNo);
            return command.ExecuteNonQuery();


        }
    }
}
