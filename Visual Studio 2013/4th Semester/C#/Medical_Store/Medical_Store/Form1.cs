using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sellMedicineUserControl1.BringToFront();

            //for side pannel
            SidePanel.Height = button1.Height;
            SidePanel.Location = button1.Location;


            //IconS
            //notifyIcon1.Icon = SystemIcons.Application;
            //notifyIcon1.BalloonTipText = "This is your first Notification ever Asif...";
            //notifyIcon1.ShowBalloonTip(1000);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sellMedicineUserControl1.BringToFront();
           // SidePanel.Width = button1.Width;
            SidePanel.Height = button1.Height;
            SidePanel.Location = button1.Location;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manageEmployeeUserContol1.BringToFront();
           // SidePanel.Width = button2.Width;
            SidePanel.Height = button2.Height;
            SidePanel.Location = button2.Location;
        }

        private void manageEmployeeUserContol1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            buyMedicineUserControl11.BringToFront();
            SidePanel.Height = button3.Height;
            SidePanel.Location = button3.Location;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void buyMedicineUserControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
