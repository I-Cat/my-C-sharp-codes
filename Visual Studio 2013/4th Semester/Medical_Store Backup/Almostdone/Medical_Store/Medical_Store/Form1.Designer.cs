namespace Medical_Store
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buyMedicineUserControl11 = new Medical_Store.BuyMedicineUserControl1();
            this.sellMedicineUserControl1 = new Medical_Store.SellMedicineUserControl();
            this.manageEmployeeUserContol1 = new Medical_Store.ManageEmployeeUserContol();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(8)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 41);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1334, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 32);
            this.button7.TabIndex = 0;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 687);
            this.panel2.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(8)))), ((int)(((byte)(71)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 76);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 62);
            this.SidePanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Medical_Store.Properties.Resources._499895;
            this.pictureBox1.Location = new System.Drawing.Point(26, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(3, 404);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 59);
            this.button6.TabIndex = 2;
            this.button6.Text = "Sell Medicine";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.Image = global::Medical_Store.Properties.Resources.Notification_32px;
            this.button5.Location = new System.Drawing.Point(3, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 59);
            this.button5.TabIndex = 2;
            this.button5.Text = "Sell Medicine";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Image = global::Medical_Store.Properties.Resources.Add_User_Male_32px;
            this.button4.Location = new System.Drawing.Point(12, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 59);
            this.button4.TabIndex = 2;
            this.button4.Text = "Sell Medicine";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "Buy Medicine";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "Manage Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sell Medicine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.buyMedicineUserControl11);
            this.panel3.Controls.Add(this.sellMedicineUserControl1);
            this.panel3.Controls.Add(this.manageEmployeeUserContol1);
            this.panel3.Location = new System.Drawing.Point(154, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1217, 687);
            this.panel3.TabIndex = 2;
            // 
            // buyMedicineUserControl11
            // 
            this.buyMedicineUserControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buyMedicineUserControl11.Location = new System.Drawing.Point(0, -1);
            this.buyMedicineUserControl11.Name = "buyMedicineUserControl11";
            this.buyMedicineUserControl11.Size = new System.Drawing.Size(1214, 687);
            this.buyMedicineUserControl11.TabIndex = 2;
            this.buyMedicineUserControl11.Load += new System.EventHandler(this.buyMedicineUserControl11_Load);
            // 
            // sellMedicineUserControl1
            // 
            this.sellMedicineUserControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sellMedicineUserControl1.Location = new System.Drawing.Point(0, -2);
            this.sellMedicineUserControl1.Name = "sellMedicineUserControl1";
            this.sellMedicineUserControl1.Size = new System.Drawing.Size(1214, 687);
            this.sellMedicineUserControl1.TabIndex = 1;
            // 
            // manageEmployeeUserContol1
            // 
            this.manageEmployeeUserContol1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.manageEmployeeUserContol1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageEmployeeUserContol1.Location = new System.Drawing.Point(0, 1);
            this.manageEmployeeUserContol1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manageEmployeeUserContol1.Name = "manageEmployeeUserContol1";
            this.manageEmployeeUserContol1.Size = new System.Drawing.Size(1214, 686);
            this.manageEmployeeUserContol1.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 728);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ManageEmployeeUserContol manageEmployeeUserContol1;
        private SellMedicineUserControl sellMedicineUserControl1;
        private BuyMedicineUserControl1 buyMedicineUserControl11;
        private System.Windows.Forms.Panel SidePanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

