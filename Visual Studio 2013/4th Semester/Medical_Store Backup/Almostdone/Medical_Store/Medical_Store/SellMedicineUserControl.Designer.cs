namespace Medical_Store
{
    partial class SellMedicineUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.gdvSell = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnterQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSearchMedicineForSell = new System.Windows.Forms.ComboBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSell)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Medicine:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTotalPrice);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.gdvSell);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(145, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 549);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sell Medicine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(206, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "TotalPrice:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(309, 495);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(24, 18);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "00";
            // 
            // gdvSell
            // 
            this.gdvSell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvSell.ContextMenuStrip = this.contextMenuStrip1;
            this.gdvSell.Location = new System.Drawing.Point(36, 98);
            this.gdvSell.Name = "gdvSell";
            this.gdvSell.Size = new System.Drawing.Size(850, 369);
            this.gdvSell.TabIndex = 1;
            this.gdvSell.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.gdvSell_CellContextMenuStripNeeded);
            this.gdvSell.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gdvSell_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete,
            this.Edit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(107, 22);
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(107, 22);
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.27481F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.72519F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblquantity, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMedicineName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblprice, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEnterQuantity, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl3, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(840, 28);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.BackColor = System.Drawing.Color.Yellow;
            this.lblquantity.Location = new System.Drawing.Point(246, 0);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblquantity.Size = new System.Drawing.Size(24, 18);
            this.lblquantity.TabIndex = 0;
            this.lblquantity.Text = "00";
            this.lblquantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.BackColor = System.Drawing.Color.Yellow;
            this.lblMedicineName.Location = new System.Drawing.Point(57, 0);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMedicineName.Size = new System.Drawing.Size(24, 18);
            this.lblMedicineName.TabIndex = 0;
            this.lblMedicineName.Text = "00";
            this.lblMedicineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Yellow;
            this.lblprice.Location = new System.Drawing.Point(370, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(24, 18);
            this.lblprice.TabIndex = 0;
            this.lblprice.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Available Qunty:";
            // 
            // txtEnterQuantity
            // 
            this.txtEnterQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterQuantity.Location = new System.Drawing.Point(685, 3);
            this.txtEnterQuantity.Name = "txtEnterQuantity";
            this.txtEnterQuantity.Size = new System.Drawing.Size(114, 21);
            this.txtEnterQuantity.TabIndex = 0;
            this.txtEnterQuantity.TextChanged += new System.EventHandler(this.txtEnterQuantity_TextChanged);
            this.txtEnterQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterQuantity_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Enter Quantity:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Yellow;
            this.lbl3.Location = new System.Drawing.Point(467, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl3.Size = new System.Drawing.Size(22, 18);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "ID";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Yellow;
            this.lblID.Location = new System.Drawing.Point(496, 0);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblID.Size = new System.Drawing.Size(24, 18);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "00";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            // 
            // cmbSearchMedicineForSell
            // 
            this.cmbSearchMedicineForSell.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearchMedicineForSell.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchMedicineForSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchMedicineForSell.FormattingEnabled = true;
            this.cmbSearchMedicineForSell.Location = new System.Drawing.Point(457, 70);
            this.cmbSearchMedicineForSell.Name = "cmbSearchMedicineForSell";
            this.cmbSearchMedicineForSell.Size = new System.Drawing.Size(257, 26);
            this.cmbSearchMedicineForSell.TabIndex = 0;
            this.cmbSearchMedicineForSell.SelectedIndexChanged += new System.EventHandler(this.cmbSearchMedicineForSell_SelectedIndexChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(921, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "New Order";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(457, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 24);
            this.textBox1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Customer Name:";
            // 
            // button2
            // 
            this.button2.Image = global::Medical_Store.Properties.Resources.Enter_25px;
            this.button2.Location = new System.Drawing.Point(543, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 47);
            this.button2.TabIndex = 0;
            this.button2.Text = "Submit Order";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Medical_Store.Properties.Resources.Cancel_25px;
            this.button1.Location = new System.Drawing.Point(735, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellMedicineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmbSearchMedicineForSell);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "SellMedicineUserControl";
            this.Size = new System.Drawing.Size(1214, 687);
            this.Load += new System.EventHandler(this.SellMedicineUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSell)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gdvSell;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.TextBox txtEnterQuantity;
        private System.Windows.Forms.ComboBox cmbSearchMedicineForSell;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}
