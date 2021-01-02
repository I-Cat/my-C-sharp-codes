using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Medical_Store
{
    public partial class SellMedicineUserControl : UserControl
    {
        int i=0;int j=0;int k=0;

        public SellMedicineUserControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void bunifuTextbox1_Leave(object sender, EventArgs e)
        {
            //if (txtSearchMedicineSell.text == "")
            //{
            //    txtSearchMedicineSell.text = "serch medicine";
            //}
        }

        private void SellMedicineUserControl_Load(object sender, EventArgs e)
        {   string selectMedicineQuerry = "Select * from Medicine";
            SqlDataReader reader = ConnectionManager.GetConnectedData(selectMedicineQuerry);

            while (reader.Read())
            {

                string medicineName = reader["MedicineName"].ToString();

                cmbSearchMedicineForSell.Items.Add(medicineName);
     
            }
        }

        private void cmbSearchMedicineForSell_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qry = "Select * from Medicine where MedicineName='" + cmbSearchMedicineForSell.Text + "'";

            SqlDataReader reader = ConnectionManager.GetConnectedData(qry);

            while (reader.Read())
            {
                lblMedicineName.Text = reader["MedicineName"].ToString();
                lblprice.Text = reader["Price"].ToString();
                lblquantity.Text = reader["Quantity"].ToString();
                lblID.Text = reader["IdentityNo"].ToString();
            }
        }

        public static int SetItemsToCart(string mName,int mPrice,int mQuantity,int total)
        {
            string addQuerry = "Insert into CartItems values(@medicineName,@Price,@Quantity,@total)";
            SqlConnection conn = ConnectionManager.GetConnection();
            SqlCommand cmd = new SqlCommand(addQuerry, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@medicineName", mName);
            cmd.Parameters.AddWithValue("@Price", mPrice);
            cmd.Parameters.AddWithValue("@Quantity", mQuantity);
            cmd.Parameters.AddWithValue("@total", total);

           return cmd.ExecuteNonQuery();

        }
        public static int gdvRows = 4;
       //to store quantity,id and qaunatity before Sell 
        int[] quantityBefore = new int[gdvRows+1];
        int[] quantityToSell = new int[gdvRows+1];
        int[] medicineID = new int[gdvRows+1];
        private void txtEnterQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                string mName = lblMedicineName.Text;
                int mPrice = int.Parse(lblprice.Text);
                if (txtEnterQuantity.Text == "")
                {
                    MessageBox.Show("Please Enter Quantity.");
                }
                else
                {
                    int   mQuqntity = int.Parse(txtEnterQuantity.Text);
                    int  mTotal = mPrice * mQuqntity;
                    int rows = SetItemsToCart(mName, mPrice, mQuqntity, mTotal);
    
                    if (rows <= 0)
                    {
                        MessageBox.Show("Error in Adding in Cart.");
                    }
                    else
                    {
                        //All is well
                    }
                  
                    quantityBefore[i] = int.Parse(lblquantity.Text);
                    quantityToSell[j] = mQuqntity;
                    medicineID[k] = int.Parse(lblID.Text);
                    i++; j++; k++;

                }
                 DataSet ds = Medicine.GetMedicineDisconnectedData();
                 gdvSell.DataSource = ds.Tables["CartItems"];

                #region
                // List<String> list=new List<string>();
                //list.Add(lblMedicineName.Text);
                //MessageBox.Show("you pressed Enter.");
                //DataGridViewColumn column = new DataGridViewTextBoxColumn();
                //column.DataPropertyName = "Name";
                //column.Name = "Knight";
                //gdvSell.Columns.Add(column);

                //column = new DataGridViewCheckBoxColumn();
                //column.DataPropertyName = "GoodGuy";
                //column.Name = "Good";
                //gdvSell.Columns.Add(column);

                //column = new DataGridViewButtonColumn();
                //column.DataPropertyName = "Remove";
                //column.Name = "Remove";

                //gdvSell.Columns.Add(column);
                #endregion
            }
        }

        private void txtEnterQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addQuerry = "delete from CartItems DBCC CHECKIDENT ('[CartItems]', RESEED, 0)";
           
            SqlConnection conn = ConnectionManager.GetConnection();
            SqlCommand cmd = new SqlCommand(addQuerry, conn);
            cmd.CommandType = CommandType.Text;

          int r=  cmd.ExecuteNonQuery();
            if(r>0)
            {
                MessageBox.Show("Deleted.","Confirmation");
            }
            
            //to clear the Grid view from items
            gdvSell.DataSource = null;
            gdvSell.Rows.Clear();
            Medicine.ds.Clear();
        }

        private void gdvSell_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gdvSell.Rows.Count >= 1)
            {
                printDialog1.ShowDialog();
                //foreach (var item in quantityBefore)
                //    {
                //         listBox1.Items.Add(item);
		 
                //   }

            }
            else
            {
                MessageBox.Show("You must add some items Before submitting order.");
            }
            //int sellQuantity=int.Parse(txtEnterQuantity.Text);
            //int quantityBeforeSell=int.Parse(lblquantity.Text);
            //int medicineId=int.Parse(lblID.Text);

            //int rows = Medicine.UpdateMedicineOnSell(sellQuantity, quantityBeforeSell, medicineId);
           // int rows =
                Medicine.UpdateMedicineOnSell(quantityBefore, quantityToSell, medicineID);
            
       //if (rows > 0)
       //{
       //    MessageBox.Show("Updated on Sell");
       //}
       //else
       //{
       //    MessageBox.Show("could not Updated on Sell.");
            
       //}
       
        }

    }
}
