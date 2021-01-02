using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Appliction
{
    public partial class Form1 : Form
    {
     
        static int x=10, y;
        public Form1()
        {
            InitializeComponent();
         // x=ClientRectangle.Width;
         //y = ClientRectangle.Height;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            x = trackBar1.Value;
            label1.Text = x.ToString();
        }

          
       
        Bitmap bmp = new Bitmap(671,445);
        Pen p = new Pen(Color.Red,x);
        bool drawing = false;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing)
                drawing = false;
            else
                drawing = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (drawing)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(p, e.X, e.Y, 2,2);
                pictureBox1.Image = bmp;
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void limeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Lime;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

      
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Png Image|*.png | Bitmap Image|*.Bmp | ICon File |*.ico";
            save.Title = "Save Image As";
            save.ShowDialog();


            if (save.FileName != "")
            {
                //Path where to save file which will be saved that loction by user
                System.IO.FileStream fs = (System.IO.FileStream)save.OpenFile();

                try
                {
                    switch (save.FilterIndex)
                    {
                        case 1:
                            this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                            break;

                        case 2:
                            this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case 3:
                            this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Icon);
                            break;

                    }
                }

                catch (Exception exp)
                {
                    MessageBox.Show("Error in Saving because i,age is Empty");
                }

            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
