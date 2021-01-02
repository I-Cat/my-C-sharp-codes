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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gdvSell = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnterQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSearchMedicineForSell = new System.Windows.Forms.ComboBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSell)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Medicine:";
            // 
            // groupBox1
            // 
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 47);
            this.button2.TabIndex = 0;
            this.button2.Text = "Submit Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(735, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gdvSell
            // 
            this.gdvSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvSell.ContextMenuStrip = this.contextMenuStrip1;
            this.gdvSell.Location = new System.Drawing.Point(36, 98);
            this.gdvSell.Name = "gdvSell";
            this.gdvSell.Size = new System.Drawing.Size(850, 369);
            this.gdvSell.TabIndex = 1;
            this.gdvSell.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.gdvSell_CellContextMenuStripNeeded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.45578F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.54422F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
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
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.BackColor = System.Drawing.Color.Yellow;
            this.lblquantity.Location = new System.Drawing.Point(257, 0);
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
            this.lblMedicineName.Location = new System.Drawing.Point(56, 0);
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
            this.lblprice.Location = new System.Drawing.Point(381, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(24, 18);
            this.lblprice.TabIndex = 0;
            this.lblprice.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            // 
            // txtEnterQuantity
            // 
            this.txtEnterQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterQuantity.Location = new System.Drawing.Point(696, 3);
            this.txtEnterQuantity.Name = "txtEnterQuantity";
            this.txtEnterQuantity.Size = new System.Drawing.Size(114, 21);
            this.txtEnterQuantity.TabIndex = 0;
            this.txtEnterQuantity.TextChanged += new System.EventHandler(this.txtEnterQuantity_TextChanged);
            this.txtEnterQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterQuantity_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Available Qunty:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(580, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Enter Quantity:";
            // 
            // cmbSearchMedicineForSell
            // 
            this.cmbSearchMedicineForSell.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearchMedicineForSell.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchMedicineForSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchMedicineForSell.FormattingEnabled = true;
            this.cmbSearchMedicineForSell.Location = new System.Drawing.Point(451, 21);
            this.cmbSearchMedicineForSell.Name = "cmbSearchMedicineForSell";
            this.cmbSearchMedicineForSell.Size = new System.Drawing.Size(257, 26);
            this.cmbSearchMedicineForSell.TabIndex = 0;
            this.cmbSearchMedicineForSell.SelectedIndexChanged += new System.EventHandler(this.cmbSearchMedicineForSell_SelectedIndexChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Yellow;
            this.lbl3.Location = new System.Drawing.Point(478, 0);
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
            this.lblID.Location = new System.Drawing.Point(507, 0);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblID.Size = new System.Drawing.Size(24, 18);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "00";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 174);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 3;
            // 
            // SellMedicineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmbSearchMedicineForSell);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SellMedicineUserControl";
            this.Size = new System.Drawing.Size(1214, 687);
            this.Load += new System.EventHandler(this.SellMedicineUserControl_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvSell)).EndInit();
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
        private System.Windows.Forms.ListBox listBox1;
    }
}
