using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSC2071_BSSE__ADO_Practice_
{
    class ConnectionManager
    {
        public static SqlConnection GetConnection()
        {
            string str = @" Data Source = SHAHID-CSD\SQLEXPRESS; 
                            Initial Catalog = BSSE_A_Fall17; 
                            Integrated Security = true;";

            SqlConnection connection = new SqlConnection(str);

            try
            {
                connection.Open();
            }
            catch(SqlException exp)
            {
                MessageBox.Show(exp.ToString());
            }

            return connection;
        }

        public static DataSet GetAllRecords()
        {
            string qry = "SELECT * FROM tblStudent";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds, "std");

            return ds;
        }

        public static DataSet GetRegistrationNos()
        {
            string qry = "SELECT RegistrationNo FROM tblStudent";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds, "regNo");

            return ds;
        }

        public static int AddStudent(Student std)
        {
            string qry = "INSERT INTO tblStudent VALUES(@RegistrationNo, @Name, @FatherName)";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@RegistrationNo", std.RegistrationNo);
            command.Parameters.AddWithValue("@Name", std.Name);
            command.Parameters.AddWithValue("@FatherName", std.FatherName);

            return command.ExecuteNonQuery();
        }

        public static int DeleteStudent(Student std)
        {
            string qry = "DELETE FROM tblStudent WHERE RegistrationNo = @RegistrationNo";
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@RegistrationNo", std.RegistrationNo);

            return command.ExecuteNonQuery();
        }
    }
}
