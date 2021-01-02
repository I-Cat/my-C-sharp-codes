using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace ADO
{
    class ConnectionManager
    {
        public static SqlConnection ConnectDb()
        {
            string str = ConfigurationManager.ConnectionStrings["strConnection"].ConnectionString;

            SqlConnection connection = new SqlConnection(str);
            try
            {
                connection.Open();
                MessageBox.Show("Successfully Connected");
            }
            catch (SqlException exp)
            {
                MessageBox.Show("Error in Connection!!!");
            }
            return connection;
        }
        public static int AddStudent (string RegistrationNo , string Name , string FatherName)
        {
            string qu = "insert into tblStudent values (@RegistrationNo , @Name , @FatherName)";
            SqlConnection connection = ConnectDb();

            SqlCommand command = new SqlCommand(qu, connection);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@RegistationNo", RegistrationNo);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@FatherName", FatherName);

            return command.ExecuteNonQuery();
        }

        public static int DeleteStudent(string RegistrationNo)
        {
            string qu = "delete from tblStudent where RegistationNo = @RegistrationNo";
            SqlConnection connection = ConnectDb();

            SqlCommand command = new SqlCommand(qu, connection);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);
       
            return command.ExecuteNonQuery();
        }

        public static int UpdateStudent(string RegistrationNo, string Name, string FatherName)
        {
            string qu = "update tblStudent set RegistrationNo = @RegistrationNo , Name=@Name , FatherName=@FatherName";
            SqlConnection connection = ConnectDb();

            SqlCommand command = new SqlCommand(qu, connection);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@FatherName", FatherName);

            return command.ExecuteNonQuery();
        }

        public static SqlDataReader GetConnectedData()
        {
            string qu = "select * from tblStudent";
            SqlConnection connection = ConnectDb();
            SqlCommand command = new SqlCommand(qu, connection);
            command.CommandType=CommandType.Text;
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        public static DataSet GetDisconnectedData()
        {

            string qu = "select * from tblStudent";
            SqlConnection connection = ConnectDb();
            SqlCommand command = new SqlCommand(qu, connection);
            command.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds, "tblTest");
            return ds;

        }
    }
}
