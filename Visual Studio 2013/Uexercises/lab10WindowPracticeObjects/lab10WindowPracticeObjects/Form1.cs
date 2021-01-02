using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10WindowPracticeObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            DataSet ds = ConnectionManger.GetAllRecord();
            dataGridView1.DataSource = ds.Tables["std"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ConnectionManger.GetAllRecord();

            comboBox1.DataSource = ds.Tables["Std"];
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "RegistrationNo";
            comboBox1.ValueMember = "Location";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student std = new Student(txtName.Text,txtRegno.Text, txtlocation.Text);
            
            int rows = ConnectionManger.AddStudent(std);
            if (rows > 0)
                MessageBox.Show("Record Added!!");
            else
                MessageBox.Show("Error in Adding"); 
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string regnoo = dataGridView1.SelectedCells[0].Value.ToString();
            Student std1 = new Student(regnoo);
            DialogResult dr = MessageBox.Show("Are You sure?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                ConnectionManger.DeleteStudent(std1);
                MessageBox.Show("Deleted!!");
            }
            else
            {
                MessageBox.Show("Cancelled");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedValue.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Clicked");
        }
    }
}
