using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
namespace Medical_Store
{
    class ConnectionManager
    {


        public static SqlConnection GetConnection()
        {
            string str = ConfigurationManager.ConnectionStrings["strConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(str);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error","Error in connecting to DataBase.");
               
            }
            return connection;
        }

        public static SqlDataReader GetConnectedData(string queery)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(queery, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
     
        public static  DataSet ds = new DataSet();
        public static DataSet GetDisconnectedEmpData(string qry)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "Employee");
            return ds;
        }

    }
}
