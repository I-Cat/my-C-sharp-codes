using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Splash_screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread trd = new Thread(new ThreadStart(formrun));
            trd.Start();
            Thread.Sleep(10000);
            InitializeComponent();
            trd.Abort();
        }

        private void formrun()
        {
           
            Application.Run(new Splash());
            
        }

        private void toggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleSwitch1.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color;
            color = comboBox1.Text;
            if (comboBox1.Text == "None")
            {
                this.BackColor = Color.FromKnownColor(KnownColor.Control);

            }
            else
            this.BackColor = Color.FromName(color);
           
        }
    }
}
