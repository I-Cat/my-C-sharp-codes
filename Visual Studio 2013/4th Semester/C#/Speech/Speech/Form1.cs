using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using Speech.Properties;
namespace Speech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Rate = trackBar2.Value;
            sp.Volume = trackBar1.Value;
            if (comboBox1.Text == "Male")
            {
                sp.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Child);
            }
            else if (comboBox1.Text == "Female")
            {
                sp.SelectVoiceByHints(VoiceGender.Female,VoiceAge.Adult);
            }

            if (textBox1.Text == "")
            {
                
                sp.Speak("please enter the test first");
            }
            else
            sp.Speak(textBox1.Text);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources._1__2_;
         
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.a1;
            PictureBox p = new PictureBox();
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Message m = new Message();
            MessageBox.Show("hello");
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
