using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircularButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
  
            InitializeComponent();
        }

        private void circularButtons2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(circularButtons2.Location.X.ToString()+ " " + circularButtons2.Location.Y.ToString());
            MessageBox.Show("Hello Asif........", "Welcome Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }
    }
}
