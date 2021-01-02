using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lecture
{
    class ConnectionMangers
    {
        public static SqlConnection ConnectDb()
        {

            string str = ConfigurationManager.ConnectionStrings["strconnection"].ConnectionString;
           // string str = @"Data Source=ASIF\SQLEXPRESS;Initial Catalog= Student;  Integrated Security=true; ";
            //1 sever name
            //2  database name in Server
            //3 To secure the connection

            SqlConnection connection = new SqlConnection(str);

            try
            {
                connection.Open();//it will open the Connection of str
                MessageBox.Show("Connected SuccesFully!");
            }
            catch
            {
                MessageBox.Show("Error in Connection");
            }

            return connection;
        }

        public static int AddStudent(string Name,string RegistrationNo,string Location)
        {
            string qry="insert into Stu values(@Name,@RegistrationNo,@Location)";//never use + sign (sql injection) use @ instsd of +
            SqlConnection connection=ConnectDb();

            SqlCommand command=new SqlCommand(qry,connection);
            command.CommandType=CommandType.Text;//to tell the type of command

            command.Parameters.AddWithValue("@Name",Name);
            command.Parameters.AddWithValue("@RegistrationNo",RegistrationNo);
            command.Parameters.AddWithValue("@Location",Location);

            return command.ExecuteNonQuery();

        }

        public static int DeleteStudent(string RegistrationNo)
        {
            string qry = "Delete from Stu where(RegistrationNo=@RegistrationNo)";//never use + sign (sql injection) use @ instsd of +
            SqlConnection connection = ConnectDb();

            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;//to tell the type of command

            command.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);

            return command.ExecuteNonQuery();

        }

        public static int UpdateStudent(string Name, string RegistrationNo, string Location)
        {
            string qry = "update Stu set Name=@Name,RegistrationNo=@RegistrationNo,Location=@Location where Location=@Location";//never use + sign (sql injection) use @ instsd of +
            SqlConnection connection = ConnectDb();

            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;//to tell the type of command

            command.Parameters.AddWithValue("@Name",Name);
            command.Parameters.AddWithValue("@RegistrationNo", RegistrationNo);
            command.Parameters.AddWithValue("@Location", Location);
           
          //  return command.ExecuteScalar();
            return command.ExecuteNonQuery();
           

        }

        public static SqlDataReader GetConnectedData()
        {
            string qry = "Select* from Stu";
            SqlConnection connection = ConnectDb();
            SqlCommand command = new SqlCommand(qry,connection);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);//command behaviour will close the connection automatically
            return reader;
        }



        public static DataSet GetDissconnectedData()
        {
            SqlConnection connection = ConnectDb();
            string qry = "Select* from Stu";
            
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(ds,"Stu");//instead of stu u can use any name

            return ds;  

        }
    }
}
