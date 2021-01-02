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

namespace CSC2071_BSSE__ADO_Practice_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            DataSet ds = ConnectionManager.GetAllRecords();
            grdData.DataSource = ds.Tables["std"];
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student std = new Student(txtRegNo.Text, txtName.Text, txtFatherName.Text);
            int rows = ConnectionManager.AddStudent(std);
            if (rows > 0)
                MessageBox.Show("Record Added");
            else
                MessageBox.Show("Error!!!");
        }

        private void grdData_MouseClick(object sender, MouseEventArgs e)
        {
            string regNo = grdData.SelectedCells[0].Value.ToString();
            Student std=new Student(regNo);

            DialogResult dr = MessageBox.Show("Are You Sure???", "Confirm Deletion", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                ConnectionManager.DeleteStudent(std);
                MessageBox.Show("Receord Deleted");
            }

            else
                MessageBox.Show("Cancelled!!!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ConnectionManager.GetAllRecords();
            cmbRegistrationNos.DataSource = ds.Tables["std"];
            cmbRegistrationNos.DisplayMember = "Name";
            cmbRegistrationNos.ValueMember = "RegistrationNo";
        }

        private void cmbRegistrationNos_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbRegistrationNos.SelectedValue.ToString());
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
