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
    public partial class AddnewStudent : Form
    {
        public AddnewStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regNo = txtregno.Text;
            string name = txtName.Text;
            string location = txtLocation.Text;

            int rows = ConnectionMangers.AddStudent(name,regNo, location);

            if (rows > 0)
            {
                MessageBox.Show("Student Added SuccessFully!!");

            }
            else
            {
                MessageBox.Show("Error in Adding Student");
            }

            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
