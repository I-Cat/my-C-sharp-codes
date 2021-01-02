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
using System.Reflection;

namespace Medical_Store
{
    public partial class SellMedicineUserControl : UserControl
    {
        DataTable salesDataTable;        
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
            tableLayoutPanel1.Visible = true;
            SqlDataReader reader = ConnectionManager.GetConnectedData(qry);

            while (reader.Read())
            {
            //   label5.Text= string.Format("name:{0} Price:{1}", reader["MedicineName"].ToString(), reader["Price"].ToString());
                lblMedicineName.Text = reader["MedicineName"].ToString();
                lblprice.Text = reader["Price"].ToString();
                lblquantity.Text = reader["Quantity"].ToString();
                lblID.Text = reader["IdentityNo"].ToString();
            }

            txtEnterQuantity.Focus();
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

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {

                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }


        List<SalesStockDetails> salesList = new List<SalesStockDetails>();
        private void txtEnterQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                #region
                //string mName = lblMedicineName.Text;
                //int mPrice = int.Parse(lblprice.Text);
                //if (txtEnterQuantity.Text == "")
                //{
                //    MessageBox.Show("Please Enter Quantity.");
                //}
                //else
                //{
                //    int   mQuqntity = int.Parse(txtEnterQuantity.Text);
                //    int  mTotal = mPrice * mQuqntity;
                //    int rows = SetItemsToCart(mName, mPrice, mQuqntity, mTotal);
    
                //    if (rows <= 0)
                //    {
                //        MessageBox.Show("Error in Adding in Cart.");
                //    }
                //    else
                //    {
                //        //All is well
                //    }
                //    var m = new Medicine(1, "as", "we", 23, 33, "er", "dsfs", DateTime.Parse(DateTime.Now.ToString()));
                //    var num = new List<Medicine>();
                //    num.Add(m);

                //    foreach (var item in num)
                //    {
                //        MessageBox.Show("" + item.IdentityNo +" "+item.MedicineDetails );
                //    }
                //}
                // DataSet ds = Medicine.GetMedicineDisconnectedData();
                // gdvSell.DataSource = ds.Tables["CartItems"];
#endregion
              //
                
                
                int tempQuantity;
                bool isNumeric = int.TryParse(txtEnterQuantity.Text.Trim(), out tempQuantity);

                
                if (!isNumeric)
                {
                    MessageBox.Show("Quantity can be only integer value.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (int.Parse(lblquantity.Text) >= int.Parse(txtEnterQuantity.Text))
                    {
                        SalesStockDetails salesStock = new SalesStockDetails();

                        salesStock.MediCineID = lblID.Text;
                        salesStock.MedicineName= lblMedicineName.Text;
                        salesStock.Price = double.Parse(lblprice.Text);
                        salesStock.Quantity = double.Parse(txtEnterQuantity.Text);

                        salesStock.TotalPrice = salesStock.Price * salesStock.Quantity;

                        // var salesList = new List<SalesStockDetails>();
                        salesList.Add(salesStock);
                        salesDataTable = ToDataTable<SalesStockDetails>(salesList);
                        gdvSell.AutoGenerateColumns = true;
                        gdvSell.DataSource = salesDataTable;
                        txtEnterQuantity.Clear();
                        cmbSearchMedicineForSell.Focus();

                        UpdateTotalPrice();
                    }
                    else
                    {
                        MessageBox.Show("Sorry Item is out of stock.", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
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

        double totalPrice;
        public void UpdateTotalPrice()
        {
            totalPrice = 0;
            foreach (var item in salesList)
            {
                totalPrice = totalPrice + item.TotalPrice;
 
            }
            lblTotalPrice.Text = totalPrice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            totalPrice = 0;
            lblTotalPrice.Text = "00";
            if (gdvSell.Rows.Count > 0)
            {
                gdvSell.DataSource = null;
                gdvSell.Rows.Clear();
                salesDataTable.Clear();
                salesList.Clear();
            }
            #region
            //  SqlConnection conn = ConnectionManager.GetConnection();
          //  SqlCommand cmd = new SqlCommand(addQuerry, conn);
          //  cmd.CommandType = CommandType.Text;

          //int r=  cmd.ExecuteNonQuery();
          //  if(r>0)
          //  {
          //      MessageBox.Show("Deleted.","Confirmation");
          //  }
            
          //  //to clear the Grid view from items
          //  gdvSell.DataSource = null;
          //  gdvSell.Rows.Clear();
            //  Medicine.ds.Clear();
            #endregion
        }

        private void gdvSell_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            //try
            //{
                //if(( MessageBox.Show("Are you sure to submit order?", "Please Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)==DialogResult.OK)
            if (txtCustomerName.Text == "")
            {

                MessageBox.Show("please Enter customer \'Name\' Before submitting order.");

            }
            else
            {
                //if data gridview not empty
                int itemsInCart = gdvSell.Rows.Count;

                if (itemsInCart >= 1)
                {

                    //printDialog1.ShowDialog();
                    //   printDocument1.Print();
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                    foreach (var item in salesList)
                    {

                        Medicine.UpdateMedicineOnSell(item.Quantity, item.MediCineID);
                    }
                }

                else
                {
                    MessageBox.Show("You must add some items Before submitting order.");
                }

            }
           
        }
   
       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap objBitmap = new Bitmap(this.gdvSell.Width, this.gdvSell.Height);
            //gdvSell.DrawToBitmap(objBitmap, new Rectangle(0, 100, this.gdvSell.Width, this.gdvSell.Height));
            //e.Graphics.DrawImage(objBitmap, 10, 10);
            e.Graphics.DrawString("Dated: "+ DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new Point(700, 0));
            e.Graphics.DrawString("\n\nCare Medical Store\n\tsaleemi chowk\n\tFaisalabad ", new Font("Arial", 27, FontStyle.Italic), Brushes.Black, new Point(150, -80));
    
            e.Graphics.DrawString("Customer Name: ", new Font("Arial", 13, FontStyle.Italic), Brushes.Black, new Point(0, 150));
            e.Graphics.DrawString(txtCustomerName.Text, new Font("Arial", 13, FontStyle.Italic), Brushes.Black, new Point(140, 150));
            e.Graphics.DrawString("----------------------------------------------------------------------", new Font("Arial", 22, FontStyle.Italic), Brushes.Black, new Point(10, 160));

            e.Graphics.DrawString("Item Name", new Font("Arial", 17, FontStyle.Italic), Brushes.Black, new Point(20, 182));
            e.Graphics.DrawString("Price", new Font("Arial", 17, FontStyle.Italic), Brushes.Black, new Point(250, 182));
            e.Graphics.DrawString("Quantity", new Font("Arial", 17, FontStyle.Italic), Brushes.Black, new Point(400, 182));
            e.Graphics.DrawString("Total Price", new Font("Arial", 17, FontStyle.Italic), Brushes.Black, new Point(620, 182));
            
            e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 22, FontStyle.Italic), Brushes.Black, new Point(10, 200));

            int yPosition = 250;
          //  int xPosition = 20;
            int count = 1;
            foreach (var item in salesList)
            {
                e.Graphics.DrawString(count.ToString()+".", new Font("Arial", 19, FontStyle.Italic), Brushes.Black, new Point(0, yPosition));

                e.Graphics.DrawString( item.MedicineName, new Font("Arial", 19, FontStyle.Italic), Brushes.Black, new Point(20, yPosition));
                e.Graphics.DrawString(item.Price.ToString(), new Font("Arial", 19, FontStyle.Italic), Brushes.Black, new Point(310, yPosition));
                e.Graphics.DrawString(item.Quantity.ToString(), new Font("Arial", 19, FontStyle.Italic), Brushes.Black, new Point(400, yPosition));
                e.Graphics.DrawString(item.TotalPrice.ToString(), new Font("Arial", 19, FontStyle.Italic), Brushes.Black, new Point(620, yPosition));
             //y position should increase every time to dingush the items
                yPosition += 40;
                count++;
            }


            
        }

        private void gdvSell_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    var hit = gdvSell.HitTest(e.X, e.Y);
                    gdvSell.Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip1.Show(gdvSell, e.X, e.Y);
                    rowIndex = hit.RowIndex;//to delete row in delete event
                  

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error In Selecting.");
            }
           
        }
         static int rowIndex;
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                
                salesList.RemoveAt(rowIndex);
                totalPrice = 0;
                UpdateTotalPrice();

                salesDataTable = ToDataTable<SalesStockDetails>(salesList);

                gdvSell.DataSource = null;
                gdvSell.DataSource = salesDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
          
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            MessageBox.Show("updation is under production...", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            totalPrice = 0;
            cmbSearchMedicineForSell.Text = "";
            lblTotalPrice.Text = "00";
            if (gdvSell.Rows.Count > 0)
            {
                gdvSell.DataSource = null;
                gdvSell.Rows.Clear();
                salesDataTable.Clear();
                salesList.Clear();
            }
        }

    }
}
