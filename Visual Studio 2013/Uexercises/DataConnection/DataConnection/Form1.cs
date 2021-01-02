using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Stu' table. You can move, or remove it, as needed.
            this.stuTableAdapter.Fill(this.studentDataSet.Stu);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.stuTableAdapter.FillBy(this.studentDataSet.Stu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("jgjhg");
        }
    }
}
