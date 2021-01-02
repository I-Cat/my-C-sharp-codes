using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Store
{
    public partial class SellMedicineUserControl : UserControl
    {
        public SellMedicineUserControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_Enter(object sender, EventArgs e)
        {
            bunifuTextbox1.text = "";
            
        }

        private void bunifuTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuTextbox1.text == "")
            {
                bunifuTextbox1.text = "serch medicine";
            }
        }
    }
}
