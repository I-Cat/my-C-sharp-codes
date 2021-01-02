using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = ConnectMe.ConnectDB();

            Form2 f2 = new Form2();
            f2.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = ConnectMe.GetConnecredData();

            while (reader.Read())
            {
                string id = reader["CustomerID"].ToString();
                string name = reader["Customer_Name"].ToString();
                string sal = reader["Customer_Salary"].ToString();
                string ads = reader["Address"].ToString();
                string phone = reader["PhoneNo"].ToString();

                string str = string.Format("{0},{1},{2},{3},{4}", id, name, sal, ads, phone);

                    comboBox1.Items.Add(str);
            }

            DataSet ds = ConnectMe.GetDisconnectedData();
            dataGridView1.DataSource=ds.Tables["Cust"];

        }
    }
}
