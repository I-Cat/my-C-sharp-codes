using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lecture
{
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionMangers.UpdateStudent(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim());
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            DataSet ds=ConnectionMangers.GetDissconnectedData();
            UpdatedataGridView.DataSource = ds.Tables["Stu"];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = ConnectionMangers.ds.Tables["Stu"].DefaultView;

            dv.RowFilter="Name Like'%" + textBox1.Text +"%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataView dv = ConnectionMangers.ds.Tables["Stu"].DefaultView;

            dv.RowFilter = "RegistrationNo Like'%" + textBox2.Text + "%'";
        }
    }
}
