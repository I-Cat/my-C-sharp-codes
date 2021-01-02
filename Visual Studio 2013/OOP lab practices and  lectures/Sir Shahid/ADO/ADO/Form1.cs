using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConnectionManager.ConnectDb();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Add_New_Student ad = new Add_New_Student();
            ad.Show();
            this.Hide();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = ConnectionManager.DeleteStudent(txtRegNo.Text.Trim());
            if(r>0)
            {
                MessageBox.Show("Record Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Error In Record Deletion");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = ConnectionManager.GetConnectedData();

            while(reader.Read())
            {
                string regNo = reader["RegistationNo"].ToString();
                string name = reader["Name"].ToString();
                string fatherName = reader["FatherName"].ToString();

                string str = string.Format("{0} , {1} ,{2}", regNo, name, fatherName);
                cmbData.Items.Add(str);
            }

            /*
             DataTable table = new DataTable();
             table.Load(reader);
             grdData.DataSource = table;
             */

            DataSet ds = ConnectionManager.GetDisconnectedData();
            grdData.DataSource = ds.Tables["tblTest"];
        }
    }
}
