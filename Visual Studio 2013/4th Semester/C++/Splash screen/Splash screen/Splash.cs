using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_screen
{
    public partial class Splash : Form
    {
        List<Color> colors = new List<Color>();
        int currentColor = 0;
       public static int a = 0;
        public Splash()
        {
            InitializeComponent();
            //colors.Add(Color.FromArgb(76, 02, 05));
            //colors.Add(Color.Beige);
            //colors.Add(Color.Black);
            //colors.Add(Color.LightBlue);
            //colors.Add(Color.LightCyan);
            //colors.Add(Color.Red);
            
            this.BackColor = Color.Red;
               

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            label1.Text = a.ToString();
          
       
            if (a == 15)
            {
                BackColor = Color.Orange;
               
            }
            if (a == 18)
            {
                BackColor = Color.Black;
            }
            if (a ==20)
            {
                BackColor = Color.Brown;
            }
               
           //     s.BackColor = Color.Black;
           
           //     s.BackColor = Color.Red;

            
           // currentColor++;
        }

        private void Splash_Load(object sender, EventArgs e)
        {

            //timer1.Enabled = true;
        }
    }
}
