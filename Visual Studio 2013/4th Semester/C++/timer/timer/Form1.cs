using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter != 18)
            {
                counter++;
                button1.Text = counter.ToString();

                // button1.Text =("18:00").ToString();
            }
            else if (counter == 18)
            {
                button1.Enabled = false;

            }
            
        }
    }
}

