using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace FileHandlingWindowForm
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            dt.Columns.Add("Col A", typeof(string));
            dt.Columns.Add("Col B", typeof(string));
            dt.Columns.Add("Col C", typeof(string));
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\ASIF ALI\Desktop\T.txt";
            string contact = string.Format("{0},{1}|", textBox1.Text, textBox2.Text);

            File.AppendAllText(path, contact);

            Process.Start(path);

            try
                {
                    StreamReader streamReader = new StreamReader(path);
                    dataGridView1.AllowUserToAddRows = true;
                    string text = "";
                    for (text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
                    {
                        string[] array = text.Split(new char[] { '|' });
                    //   dataGridView1.Rows.Add(array);
                        dt.Rows.Add(array[0],array[1]);

                    }
                    streamReader.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error" + err.Message );
                }

                dataGridView1.DataSource = dt;
            }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity-=0.05;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        }
    }


