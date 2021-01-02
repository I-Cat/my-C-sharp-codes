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
namespace lecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnectDB_Click(object sender, EventArgs e)
        {
            SqlConnection connection =  ConnectionMangers.ConnectDb();

           // MessageBox.Show(connection.State.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddnewStudent s = new AddnewStudent();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectionMangers.DeleteStudent(textBox1.Text.Trim());


        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateStudent us = new UpdateStudent();
            us.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = ConnectionMangers.GetConnectedData();
            while (reader.Read())//read() method will read the data in the reader till end
            {
                string name = reader["Name"].ToString();//gets the value of the specified column
                string regNo = reader["RegistrationNo"].ToString();
                string location = reader["Location"].ToString();
                

                string str = string.Format("{0},{1},{2}", regNo, name, location);

                comboBox1.Items.Add(str);
            }

            //DataTable table = new DataTable();
            //table.Load(reader);
            //dataGridView1.DataSource = table;

            DataSet ds = ConnectionMangers.GetDissconnectedData();
            dataGridView1.DataSource = ds.Tables["Stu"];

        }
    }
}
