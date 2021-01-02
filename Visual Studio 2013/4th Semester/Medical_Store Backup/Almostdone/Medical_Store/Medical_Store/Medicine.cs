using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Medical_Store
{
    public class Medicine
    {
        public int IdentityNo { get; set; }
        public string MedicineName { get; set; }
        public string MedicineDetails { get; set; }
        public int MedicinePrice { get; set; }
        public int MedicineQuantity { get; set; }
        public string MedicineCompony { get; set; }
        public string MedicineType { get; set; }
        public DateTime MedicineExpiryDate { get; set; }

        public Medicine()
        {

        }
        public Medicine(int id, string name, string details, int price, int quantity, string compony, string type, DateTime expiryDate)
        {
            IdentityNo = id;
            MedicineName = name;
            MedicineDetails = details;
            MedicinePrice = price;
            MedicineQuantity = quantity;
            MedicineCompony = compony;
            MedicineType = type;
            MedicineExpiryDate = expiryDate;
        }
        //public int identityNo{
        // private string medicineName;
        //  private string medicineDetails;
        // private int price;
        // private int quantity;
        //  private string medicineCompony;
        //  private string medicineType;
        //   private DateTime MedicineExpiryDate;

        #region
        /*   private int identityNo;
        private string medicineName;
        private string medicineDetails;
        private int price;
        private int quantity;
        private string medicineCompony;
        private string medicineType;
        private DateTime MedicineExpiryDate;
        public Medicine()
        {

        }
        public DateTime ExpiryDate
        {
            get { return MedicineExpiryDate; }
            set { MedicineExpiryDate = value; }
        }
        
        public string MediType
        {
            get { return medicineType; }
            set { medicineType = value; }
        }
        
        public string MedicineCompony
        {
            get { return medicineCompony; }
            set { medicineCompony = value; }
        }
        
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        
        public string Detials
        {
            get { return medicineDetails; }
            set { medicineDetails = value; }
        }
        
        public string MedicineName
        {
            get { return medicineName; }
            set { medicineName = value; }
        }
        
        public int IdentityNo
        {
            get { return identityNo; }
            set { identityNo = value; }
        }*/

        #endregion

        public static DataSet ds = new DataSet();
        public static DataSet GetMedicineDisconnectedData()
        {
            SqlConnection conn = ConnectionManager.GetConnection();
            string str = "select * from CartItems where Id= (select Max(Id) from CartItems) ";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "CartItems");
            return ds;
        }


        //medi=Medicine
        public static int AddMedicineToStock(Medicine newMedi)
        {
            string addQuerry = "Insert into Medicine values(@IdentityNo,@MedicineName,@Details,@Price,@Quantity,@ComponyName,@TypeOfMedicine,@ExpiryDate)";
            SqlConnection conn = ConnectionManager.GetConnection();
            SqlCommand cmd = new SqlCommand(addQuerry, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@IdentityNo", newMedi.IdentityNo);
            cmd.Parameters.AddWithValue("@MedicineName", newMedi.MedicineName);
            cmd.Parameters.AddWithValue("@Details", newMedi.MedicineDetails);
            cmd.Parameters.AddWithValue("@Price", newMedi.MedicinePrice);
            cmd.Parameters.AddWithValue("@Quantity", newMedi.MedicineQuantity);
            cmd.Parameters.AddWithValue("@ComponyName", newMedi.MedicineCompony);
            cmd.Parameters.AddWithValue("@TypeOfMedicine", newMedi.MedicineType);
            cmd.Parameters.AddWithValue("@ExpiryDate", newMedi.MedicineExpiryDate);

            return cmd.ExecuteNonQuery();//return the number of rows effected


        }

        public static int DeleteMedicineFromStock(string id)
        {
            string qry = "delete from Medicine where IdentityNo=@id";
            SqlConnection conn = ConnectionManager.GetConnection();
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery();
        }
        public static int UpdateMedicineStock(Medicine updateMedicine)
        {
            string qry = "update Medicine set IdentityNo=@id,MedicineName=@Name,Details=@details,TypeOfMedicine=@type,Price=@price,Quantity=@quantity,ComponyName=@compony,ExpiryDate=@expiry_date where IdentityNo=@oldID ";

            SqlConnection conn = ConnectionManager.GetConnection();
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@oldID", updateMedicine.IdentityNo);
            cmd.Parameters.AddWithValue("@id", updateMedicine.IdentityNo);
            cmd.Parameters.AddWithValue("@Name", updateMedicine.MedicineName);
            cmd.Parameters.AddWithValue("@details", updateMedicine.MedicineDetails);
            cmd.Parameters.AddWithValue("@type", updateMedicine.MedicineType);
            cmd.Parameters.AddWithValue("@price", updateMedicine.MedicinePrice);
            cmd.Parameters.AddWithValue("@quantity", updateMedicine.MedicineQuantity);
            cmd.Parameters.AddWithValue("@compony", updateMedicine.MedicineCompony);
            cmd.Parameters.AddWithValue("@expiry_date", updateMedicine.MedicineExpiryDate);

            return cmd.ExecuteNonQuery();

        }

        public static void UpdateMedicineOnSell(double quantity,string id)
        {

            string qry = "update Medicine set Quantity=Quantity-@quantity where IdentityNo=@oldID ";

            SqlConnection conn = ConnectionManager.GetConnection();
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@oldID", id);
            cmd.Parameters.AddWithValue("@quantity", quantity);

            cmd.ExecuteNonQuery();
        }

    }
    // return 0;

    public class SalesStockDetails
    {
        public string ItemID { get; set; }
      //  public string Customer { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double TotalPrice { get; set; }
        



    }
  
}

