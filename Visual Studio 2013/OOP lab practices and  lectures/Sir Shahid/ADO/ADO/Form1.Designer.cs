namespace ADO
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
            this.btnConnection = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbData = new System.Windows.Forms.ComboBox();
            this.grdData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(12, 29);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(117, 60);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "Connect DB";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Load Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(658, 46);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(247, 20);
            this.txtRegNo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registration NO";
            // 
            // cmbData
            // 
            this.cmbData.FormattingEnabled = true;
            this.cmbData.Location = new System.Drawing.Point(12, 121);
            this.cmbData.Name = "cmbData";
            this.cmbData.Size = new System.Drawing.Size(426, 21);
            this.cmbData.TabIndex = 5;
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(466, 121);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(456, 389);
            this.grdData.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 511);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.cmbData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbData;
        private System.Windows.Forms.DataGridView grdData;
    }
}

