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
namespace Practice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id=int.Parse(textBox1.Text);
            string name = textBox2.Text;
            string sal=textBox3.Text;
            string adres = textBox4.Text;
            string ph = textBox5.Text;

            int rows = ConnectMe.AddCustomer(id, name, sal, adres, ph);
            if (rows > 0)
            {
                MessageBox.Show("Ädded!");

            }
            else
                MessageBox.Show("Error in Adding!");
        }
    }
}
