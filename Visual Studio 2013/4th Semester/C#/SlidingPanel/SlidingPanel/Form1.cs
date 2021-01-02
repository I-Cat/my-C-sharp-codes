using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingPanel
{
    public partial class Form1 : Form
    {
        int PanelWidth;
        bool Hidden = false;
        public Form1()
        {
            InitializeComponent();
            PanelWidth = panelSlide.Width;
            Hidden = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panelSlide.Width = panelSlide.Width + 10;
                if (panelSlide.Width >= PanelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
                panelSlide.Width = panelSlide.Width - 10;
            if (panelSlide.Width<=0)
            {
                timer1.Stop();
                Hidden = true;
                this.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
