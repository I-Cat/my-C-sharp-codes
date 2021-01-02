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
    public partial class ManageEmployeeUserContol : UserControl
    {
        public static DataSet ds = new DataSet();

        public ManageEmployeeUserContol()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            int tempSalary;
            bool IsNumeric = int.TryParse(txtAddEmpSalary.Text.Trim(), out tempSalary);
           
            try
            {
                if (txtAddNameEmp.Text == "")
                {
                    MessageBox.Show("Name Feild Is required Please fill it before submitting.");
                }
                else if (txtAddPhoneEmp.Text == "")
                {
                    MessageBox.Show("Phone Feild Is required Please fill it before submitting.");
                }
                else if (txtAddEmpQaulification.Text == "")
                {
                    MessageBox.Show("Qualification Feild Is required Please fill it before submitting.");
                }
                else if (txtAddEmpAddress.Text == "")
                {
                    MessageBox.Show("Address Feild Is required Please fill it before submitting.");
                }

                else if (txtAddEmpSalary.Text == "" || !IsNumeric)
                {
                    MessageBox.Show("Salary Feild Must be Nummeric value.");
                    txtAddEmpSalary.Focus();
                }
                    //incase all data validated
                else
                {
                    string name = txtAddNameEmp.Text;
                    string phone = txtAddPhoneEmp.Text;
                    string qualification = txtAddEmpQaulification.Text;
                    string address = txtAddEmpAddress.Text;
                    string accountType = txtAddEmpAccountType.Text;
                    int salary = int.Parse(txtAddEmpSalary.Text);
                    DateTime joinDate = DateTime.Parse(joinEmployeeDateTimePicker.Text);
                    joinDate.ToShortDateString();
                    Employee employee = new Employee(name, phone, qualification, address, accountType, salary, joinDate);


                    int rows = Employee.AddEmployeeRecord(employee);
                    if (rows > 0)
                    {
                        MessageBox.Show("Record Added Successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                        MessageBox.Show("Error in Adding new record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " Error in Adding....");

            }
       
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            string qry = "Select * from Employee";
            ds = ConnectionManager.GetDisconnectedEmpData(qry);

            EmployeedataGridView.DataSource = ds.Tables["Employee"];

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void ManageEmployeeUserContol_TabIndexChanged(object sender, EventArgs e)
        {
            //string qry = "Select * from Employee";
            //ds = ConnectionManager.GetDisconnectedEmpData(qry);

            //EmployeedataGridView.DataSource = ds.Tables["Employee"];
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            DataView dataV = ConnectionManager.ds.Tables["Employee"].DefaultView;
            dataV.RowFilter = "Name like '%" + txtEmployeeDeletSearch.Text + "%'";
       //     dataV.RowFilter = "AccountType like '%" + txtEmployeeDeletSearch.Text + "%'";

        }
        int rowindex;//for delete
        int empId;
        private void EmployeedataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var hit = EmployeedataGridView.HitTest(e.X, e.Y);
                EmployeedataGridView.Rows[hit.RowIndex].Selected = true;
                contextMenuStrip1.Show(EmployeedataGridView, e.X, e.Y);
                rowindex = hit.RowIndex;//to use in delete event

                empId = int.Parse(EmployeedataGridView.Rows[hit.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete employee?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                EmployeedataGridView.Rows.RemoveAt(rowindex);
                Employee.DeleteEmployeeRecord(empId);
                MessageBox.Show("Employee Record removed successfully.", "confirmation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void tabControl1_RegionChanged(object sender, EventArgs e)
        {
            string qry = "Select * from Employee";
            ds = ConnectionManager.GetDisconnectedEmpData(qry);

            EmployeedataGridView.DataSource = ds.Tables["Employee"];
        }
    }
}
