namespace CircularButton
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
            this.circularButtons3 = new CircularButton.CircularButtons();
            this.circularButtons2 = new CircularButton.CircularButtons();
            this.circularButtons1 = new CircularButton.CircularButtons();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // circularButtons3
            // 
            this.circularButtons3.BackColor = System.Drawing.Color.Red;
            this.circularButtons3.FlatAppearance.BorderSize = 0;
            this.circularButtons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtons3.Location = new System.Drawing.Point(331, 145);
            this.circularButtons3.Name = "circularButtons3";
            this.circularButtons3.Size = new System.Drawing.Size(85, 82);
            this.circularButtons3.TabIndex = 1;
            this.circularButtons3.Text = "circularButtons2";
            this.circularButtons3.UseVisualStyleBackColor = false;
            // 
            // circularButtons2
            // 
            this.circularButtons2.BackColor = System.Drawing.Color.Red;
            this.circularButtons2.FlatAppearance.BorderSize = 0;
            this.circularButtons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtons2.Location = new System.Drawing.Point(66, 140);
            this.circularButtons2.Name = "circularButtons2";
            this.circularButtons2.Size = new System.Drawing.Size(85, 82);
            this.circularButtons2.TabIndex = 1;
            this.circularButtons2.Text = "circularButtons2";
            this.circularButtons2.UseVisualStyleBackColor = false;
            this.circularButtons2.Click += new System.EventHandler(this.circularButtons2_DoubleClick);
            // 
            // circularButtons1
            // 
            this.circularButtons1.BackColor = System.Drawing.Color.Lime;
            this.circularButtons1.FlatAppearance.BorderSize = 0;
            this.circularButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtons1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButtons1.Location = new System.Drawing.Point(194, 140);
            this.circularButtons1.Name = "circularButtons1";
            this.circularButtons1.Size = new System.Drawing.Size(86, 87);
            this.circularButtons1.TabIndex = 0;
            this.circularButtons1.Text = "I Am Green";
            this.circularButtons1.UseVisualStyleBackColor = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = false;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.circularButtons2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 417);
            this.Controls.Add(this.circularButtons3);
            this.Controls.Add(this.circularButtons2);
            this.Controls.Add(this.circularButtons1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CircularButtons circularButtons1;
        private CircularButtons circularButtons2;
        private CircularButtons circularButtons3;
        private ns1.BunifuDragControl bunifuDragControl1;
    }
}

