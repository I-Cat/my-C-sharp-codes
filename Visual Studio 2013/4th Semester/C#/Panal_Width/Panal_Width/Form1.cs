using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panal_Width
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           // DialogResult s = MessageBox.Show("Are u Agree With Terms And Conditions?");

            InitializeComponent();
          //// if (s == DialogResult.OK)
          // {
            
          // }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 489)
            {
                panel1.Width = 600;
                button1.Text = "Decrease";
               // circularButton1.Location = new Point(panel2.Width-25,panel2.Height-118);
            }
            else if (panel1.Width == 600)
            {
            //    circularButton1.Location = new Point(panel2.Width - 25, panel2.Height - 100);

                panel1.Width =489;
                button1.Text = "Increase";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("hy");
            Form2 f = new Form2();
            f.ShowDialog();
            timer1.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            else
                panel2.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I Am Button");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();

        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
           // panel4.Visible = true;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
           // panel4.BackColor = Color.Blue;
            
          //  panel4.Visible = false ;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

          System.Drawing.Rectangle.FromLTRB(5, 5, 5, 5);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // Application.Exit();
        }
        
      
    }
}
