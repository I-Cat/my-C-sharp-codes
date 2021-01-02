using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Medical_Store
{
    public partial class BuyMedicineUserControl1 : UserControl
    {
        public BuyMedicineUserControl1()
        {
            InitializeComponent();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {

            if (txtAddMedicineIdentityNo.Text == "" || txtAddMedicineDetails.Text == "" || txtAddMedicineName.Text == ""  || txtAddMedicineCompony.Text == "" || txtAddMedicinePrice.Text == ""
                || cmbAddMedicinrType.Text == "" || dateAddTimePickerMedicineExpiry.Text == "")
            {
                MessageBox.Show("Please fill all informations before continue.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = int.Parse(txtAddMedicineIdentityNo.Text);
                int quantity = int.Parse(txtAdMedicineQuantity.Text);
                int price = int.Parse(txtAddMedicinePrice.Text);
                string name = txtAddMedicineName.Text;
                string type = cmbAddMedicinrType.Text;
                string compony = txtAddMedicineCompony.Text;
                string details = txtAddMedicineDetails.Text;
                try
                {

                    Medicine newMedicine = new Medicine(id, name, details, price, quantity, 
                                          compony, type,Convert.ToDateTime(dateAddTimePickerMedicineExpiry.Text));

                  int rows=  Medicine.AddMedicineToStock(newMedicine);
                  if (rows > 0)
                  {
                      MessageBox.Show("Record Added Successfully.","Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
                  
                  else
                      MessageBox.Show( "Error in Adding new record","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + " Error in Adding....");
                  
                }
           
            }
        }

        private void txtAddMedicineName_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAddMedicineIdentityNo_TextChanged(object sender, EventArgs e)
        {
            //if (int.Parse(txtAddMedicineIdentityNo.Text) < 7 && int.Parse(txtAddMedicineIdentityNo.Text) > 122)
            //{
            //    txtAddMedicineIdentityNo.Text = "000";
            //}
            //int number = int.Parse(txtAddMedicineIdentityNo.Text);
            //if (Char.IsDigit(number)) return;
            //if (Char.IsControl(e.KeyChar)) return;
            //e.Handled = true;
        }

        private void tabPage2_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("hello There");

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
           
        }
        
        private void cmbSearchMedicine_Click(object sender, EventArgs e)
        {
          
        
        
        }

        private void cmbSearchMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qry = "Select * from Medicine where MedicineName='" + cmbSearchMedicine.Text + "'";

            SqlDataReader reader = ConnectionManager.GetConnectedData(qry);

            while (reader.Read())
            {
                txtDeleteMediDetails.Text = reader.GetString(reader.GetOrdinal("Details"));
                //   txtDeleteMediIdentity.Text =(reader.GetString(reader.GetOrdinal("IdentityNo"))).ToString();
                txtDeleteMediIdentity.Text = reader["IdentityNo"].ToString();
                cmbDeleteMediType.Text = reader["TypeOfMedicine"].ToString();
                txtDeleteMediCompony.Text = reader["ComponyName"].ToString();
                lblExpiryDate.Text = reader["ExpiryDate"].ToString();
            }
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            int rows = Medicine.DeleteMedicineFromStock(txtDeleteMediIdentity.Text);

            if (rows > 0)
            {
                MessageBox.Show("Record Removed Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error in Deletion Process please connect to Asif43997@gmail.com","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
          
            cmbSearchMedicine.Items.Clear();//to clear data present already to avoid duplication
            cmbUpdateMediSearch.Items.Clear();
            string selectMedicineQuerry = "Select * from Medicine";
            SqlDataReader reader = ConnectionManager.GetConnectedData(selectMedicineQuerry);

            while (reader.Read())
            {

                string medicineName = reader["MedicineName"].ToString();
                cmbSearchMedicine.Items.Add(medicineName);
                cmbUpdateMediSearch.Items.Add(medicineName);
            }

        }

        private void cmbUpdateMediSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qry = "Select * from Medicine where MedicineName='" + cmbUpdateMediSearch.Text+ "'";

            SqlDataReader reader = ConnectionManager.GetConnectedData(qry);

            while (reader.Read())
            {
               txtUpdateMediDetail.Text = reader.GetString(reader.GetOrdinal("Details"));
               txtUpdateMediIdentityNO.Text = reader["IdentityNo"].ToString();
               cmbUpdateMediType.Text = reader["TypeOfMedicine"].ToString();
                txtUpdateMediCompony.Text = reader["ComponyName"].ToString();
                txtUpdateMediQuantity.Text = reader["Quantity"].ToString();
                txtUpdateMediName.Text = reader["MedicineName"].ToString();
                txtUpdateMediPrice.Text = reader["Price"].ToString();
                dateTimePickerUpdateExpiry.Value = DateTime.Parse(reader["ExpiryDate"].ToString());
            }

        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            try
            {
                int mediId = int.Parse(txtUpdateMediIdentityNO.Text);
                int mediprice = int.Parse(txtUpdateMediPrice.Text);
                int mediquantity = int.Parse(txtUpdateMediQuantity.Text);
                string mediType = cmbUpdateMediType.Text;
                string mediName = txtUpdateMediName.Text;
                string mediDetail = txtUpdateMediDetail.Text;
                string mediCompony = txtUpdateMediCompony.Text;
                DateTime expDate = dateTimePickerUpdateExpiry.Value;

                Medicine updateMedi = new Medicine(mediId, mediName, mediDetail, mediprice, mediquantity, mediCompony, mediType,expDate);
                int rows = Medicine.UpdateMedicineStock(updateMedi);

                if (rows > 0)
                {
                    MessageBox.Show("Record Updated Successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Error in Updation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + " check updation Parameters.");
            }
          
        }

      
    }
}
