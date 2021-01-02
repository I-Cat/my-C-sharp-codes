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
    }
}
