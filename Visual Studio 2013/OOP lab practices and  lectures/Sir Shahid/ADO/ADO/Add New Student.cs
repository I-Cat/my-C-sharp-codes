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


namespace ADO
{
    public partial class Add_New_Student : Form
    {
        public Add_New_Student()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string regNo = txtReg.Text.Trim();
            string name = txtName.Text.Trim();
            string fName = txtFName.Text.Trim();

            int r = ConnectionManager.AddStudent(regNo, name, fName);
            if(r>0)
            {
                MessageBox.Show("Student Added Successfully");
                this.Close();
            }

            else
            {
                MessageBox.Show("Error In Adding Student");
            }
        }
    }
}
