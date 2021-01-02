using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

using System.Data;

namespace Practice
{
    class ConnectMe
    {
        public static SqlConnection ConnectDB()
        {
            string str = @"Data Source=ASIF\SQLEXPRESS;Initial Catalog=ARSLAN;Integrated Security=true";

            SqlConnection con = new SqlConnection(str);
            
            try
            {
                con.Open();
                MessageBox.Show("Connected successFully");
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error!!!");

              }
            return con;
        }
        public static int AddCustomer(int id,string name,string salary,string address,string phone)
        {
            string str = "insert into Customer values(@CustomerID,@Customer_Name,@Customer_Salary,@Address,@PhoneNo)";

            SqlConnection con = ConnectDB();

            SqlCommand command = new SqlCommand(str, con);
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@Customer_Name", name);
            command.Parameters.AddWithValue("@CustomerID", id);
            command.Parameters.AddWithValue("@Customer_Salary", salary);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@PhoneNo",phone);
            
            //command.ExecuteNonQuery(); without this Query will not Execute
            int rows = command.ExecuteNonQuery();
            return rows;
        }

        public static SqlDataReader GetConnecredData()
        {
            string str = "select * from Customer";

            SqlConnection con = ConnectDB();
            SqlCommand comnd = new SqlCommand(str, con);

            comnd.CommandType = CommandType.Text;
            SqlDataReader reader = comnd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        //same work as above 

        public static DataSet GetDisconnectedData()
        {
            string str = "Select * from Customer";
            SqlConnection con = ConnectDB();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;
            DataSet ds=new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(ds, "Cust");
            return ds;
        }
    
    }

}
