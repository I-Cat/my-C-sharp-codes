namespace Splash_screen
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
//            this.toggleSwitch1 = new JCS.ToggleSwitch();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // toggleSwitch1
            // 
//            this.toggleSwitch1.Location = new System.Drawing.Point(263, 240);
//            this.toggleSwitch1.Name = "toggleSwitch1";
//            this.toggleSwitch1.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.toggleSwitch1.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.toggleSwitch1.Size = new System.Drawing.Size(45, 19);
//            this.toggleSwitch1.TabIndex = 0;
     //       this.toggleSwitch1.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.toggleSwitch1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(231, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Pink",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Gray"});
            this.comboBox1.Location = new System.Drawing.Point(541, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "None";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Back Color";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
//            this.Controls.Add(this.toggleSwitch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JCS.ToggleSwitch toggleSwitch1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuDragControl bunifuDragControl1;
    }
}

