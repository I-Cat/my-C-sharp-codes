namespace CSC2071_BSSE__ADO_Practice_
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
            this.btnLoadData = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.cmbRegistrationNos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.ForeColor = System.Drawing.Color.Black;
            this.btnLoadData.Location = new System.Drawing.Point(22, 21);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(149, 41);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(177, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSalmon;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(332, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 41);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(22, 78);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(459, 404);
            this.grdData.TabIndex = 1;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            this.grdData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdData_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(498, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "RegistrationNo";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(629, 99);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(205, 20);
            this.txtRegNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(498, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(629, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 20);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(498, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Father Name:";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(629, 151);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(205, 20);
            this.txtFatherName.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(629, 189);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(205, 23);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // cmbRegistrationNos
            // 
            this.cmbRegistrationNos.FormattingEnabled = true;
            this.cmbRegistrationNos.Location = new System.Drawing.Point(629, 263);
            this.cmbRegistrationNos.Name = "cmbRegistrationNos";
            this.cmbRegistrationNos.Size = new System.Drawing.Size(205, 21);
            this.cmbRegistrationNos.TabIndex = 5;
            this.cmbRegistrationNos.SelectedIndexChanged += new System.EventHandler(this.cmbRegistrationNos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 494);
            this.Controls.Add(this.cmbRegistrationNos);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLoadData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.ComboBox cmbRegistrationNos;
    }
}

