using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> number = new List<int>();
            for (int i = 34; i > 0; i--)
            {
                number.Add(i);
                listBox1.Items.Add(i);
            }

           
          int a= listBox1.Items.Count;
          label1.Text = a.ToString();
                                 //Lamda Expression
         var aa= number.FindAll(s => s %2==0);

  
            foreach (var item in aa)
          {
              listBox2.Items.Add(item);
          }
            
           var last= number.FindLast(n => n == 10);
           label4.Text = last.ToString();

            var sorted = number.Sum();
            label1.Text = sorted.ToString();
        
        }
    }
}
