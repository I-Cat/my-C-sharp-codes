namespace Medical_Store
{
    partial class ManageEmployeeUserContol
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAddPhoneEmp = new System.Windows.Forms.MaskedTextBox();
            this.txtAddNameEmp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAddEmpAccountType = new System.Windows.Forms.ComboBox();
            this.joinEmployeeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddEmpSalary = new System.Windows.Forms.TextBox();
            this.txtAddEmpQaulification = new System.Windows.Forms.TextBox();
            this.txtAddEmpAddress = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EmployeedataGridView = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmployeeDeletSearch = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1205, 684);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.RegionChanged += new System.EventHandler(this.tabControl1_RegionChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.txtAddPhoneEmp);
            this.tabPage1.Controls.Add(this.txtAddNameEmp);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.txtAddEmpAccountType);
            this.tabPage1.Controls.Add(this.joinEmployeeDateTimePicker);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnAddEmployee);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtAddEmpSalary);
            this.tabPage1.Controls.Add(this.txtAddEmpQaulification);
            this.tabPage1.Controls.Add(this.txtAddEmpAddress);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1197, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Employee";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtAddPhoneEmp
            // 
            this.txtAddPhoneEmp.Location = new System.Drawing.Point(163, 151);
            this.txtAddPhoneEmp.Mask = "0000-9999999";
            this.txtAddPhoneEmp.Name = "txtAddPhoneEmp";
            this.txtAddPhoneEmp.Size = new System.Drawing.Size(280, 27);
            this.txtAddPhoneEmp.TabIndex = 1;
            // 
            // txtAddNameEmp
            // 
            this.txtAddNameEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddNameEmp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddNameEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddNameEmp.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddNameEmp.HintText = "e.g Asif";
            this.txtAddNameEmp.isPassword = false;
            this.txtAddNameEmp.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtAddNameEmp.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAddNameEmp.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAddNameEmp.LineThickness = 3;
            this.txtAddNameEmp.Location = new System.Drawing.Point(166, 100);
            this.txtAddNameEmp.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddNameEmp.Name = "txtAddNameEmp";
            this.txtAddNameEmp.Size = new System.Drawing.Size(277, 21);
            this.txtAddNameEmp.TabIndex = 0;
            this.txtAddNameEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
          //  this.txtAddNameEmp.Enter += new System.EventHandler(this.txtAddNameEmp_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medical_Store.Properties.Resources.Add_User_Group_Woman_Man_96px;
            this.pictureBox1.Location = new System.Drawing.Point(579, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtAddEmpAccountType
            // 
            this.txtAddEmpAccountType.FormattingEnabled = true;
            this.txtAddEmpAccountType.Items.AddRange(new object[] {
            "Employee",
            "Manager"});
            this.txtAddEmpAccountType.Location = new System.Drawing.Point(166, 272);
            this.txtAddEmpAccountType.Name = "txtAddEmpAccountType";
            this.txtAddEmpAccountType.Size = new System.Drawing.Size(277, 29);
            this.txtAddEmpAccountType.TabIndex = 3;
            // 
            // joinEmployeeDateTimePicker
            // 
            this.joinEmployeeDateTimePicker.Location = new System.Drawing.Point(549, 36);
            this.joinEmployeeDateTimePicker.Name = "joinEmployeeDateTimePicker";
            this.joinEmployeeDateTimePicker.Size = new System.Drawing.Size(290, 27);
            this.joinEmployeeDateTimePicker.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add Picture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Gray;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddEmployee.Image = global::Medical_Store.Properties.Resources.Plus_25px;
            this.btnAddEmployee.Location = new System.Drawing.Point(233, 526);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(152, 56);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "   Add";
            this.btnAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Account Type:";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Salary:";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Qualification";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name";
            // 
            // txtAddEmpSalary
            // 
            this.txtAddEmpSalary.Location = new System.Drawing.Point(166, 330);
            this.txtAddEmpSalary.Name = "txtAddEmpSalary";
            this.txtAddEmpSalary.Size = new System.Drawing.Size(277, 27);
            this.txtAddEmpSalary.TabIndex = 4;
            // 
            // txtAddEmpQaulification
            // 
            this.txtAddEmpQaulification.Location = new System.Drawing.Point(166, 206);
            this.txtAddEmpQaulification.Name = "txtAddEmpQaulification";
            this.txtAddEmpQaulification.Size = new System.Drawing.Size(277, 27);
            this.txtAddEmpQaulification.TabIndex = 2;
            // 
            // txtAddEmpAddress
            // 
            this.txtAddEmpAddress.Location = new System.Drawing.Point(166, 368);
            this.txtAddEmpAddress.Multiline = true;
            this.txtAddEmpAddress.Name = "txtAddEmpAddress";
            this.txtAddEmpAddress.Size = new System.Drawing.Size(277, 107);
            this.txtAddEmpAddress.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.EmployeedataGridView);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtEmployeeDeletSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1197, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete Employee";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Medical_Store.Properties.Resources.Help_25px1;
            this.pictureBox2.Location = new System.Drawing.Point(466, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "                        How to Delete?\r\n(i)search any employee by name in the sea" +
        "rch box.\r\n(ii)Right click on any attributte of Employee.Delete popUp\r\n will appe" +
        "ar click on that all!!.");
            // 
            // EmployeedataGridView
            // 
            this.EmployeedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeedataGridView.Location = new System.Drawing.Point(3, 81);
            this.EmployeedataGridView.Name = "EmployeedataGridView";
            this.EmployeedataGridView.Size = new System.Drawing.Size(1191, 570);
            this.EmployeedataGridView.TabIndex = 18;
            this.EmployeedataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeedataGridView_MouseDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(42, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 21);
            this.label13.TabIndex = 16;
            this.label13.Text = "Search Employee by Name :";
            // 
            // txtEmployeeDeletSearch
            // 
            this.txtEmployeeDeletSearch.Location = new System.Drawing.Point(275, 28);
            this.txtEmployeeDeletSearch.Name = "txtEmployeeDeletSearch";
            this.txtEmployeeDeletSearch.Size = new System.Drawing.Size(185, 24);
            this.txtEmployeeDeletSearch.TabIndex = 10;
            this.txtEmployeeDeletSearch.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.textBox13);
            this.tabPage3.Controls.Add(this.textBox14);
            this.tabPage3.Controls.Add(this.textBox15);
            this.tabPage3.Controls.Add(this.textBox16);
            this.tabPage3.Controls.Add(this.textBox17);
            this.tabPage3.Controls.Add(this.textBox18);
            this.tabPage3.Controls.Add(this.textBox19);
            this.tabPage3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1197, 654);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update Employee";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-3, 261);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(834, 393);
            this.dataGridView2.TabIndex = 34;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(684, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 49);
            this.button4.TabIndex = 33;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(320, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 21);
            this.label14.TabIndex = 26;
            this.label14.Text = "Account Type:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(45, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 21);
            this.label15.TabIndex = 27;
            this.label15.Text = "Salary:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 21);
            this.label16.TabIndex = 28;
            this.label16.Text = "Qualification";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(351, 193);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 21);
            this.label17.TabIndex = 29;
            this.label17.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(327, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(130, 21);
            this.label18.TabIndex = 30;
            this.label18.Text = "Phone Number:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(5, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(364, 22);
            this.label19.TabIndex = 31;
            this.label19.Text = "Search Employee by Name To Update:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(35, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 21);
            this.label20.TabIndex = 32;
            this.label20.Text = "Full Name";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(127, 190);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(185, 24);
            this.textBox13.TabIndex = 19;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(127, 133);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(185, 24);
            this.textBox14.TabIndex = 20;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(447, 175);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(185, 80);
            this.textBox15.TabIndex = 21;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(463, 129);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(169, 24);
            this.textBox16.TabIndex = 22;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(463, 83);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(169, 24);
            this.textBox17.TabIndex = 23;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(375, 30);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(185, 24);
            this.textBox18.TabIndex = 24;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(127, 83);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(185, 24);
            this.textBox19.TabIndex = 25;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ForeColor = System.Drawing.Color.Red;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ManageEmployeeUserContol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageEmployeeUserContol";
            this.Size = new System.Drawing.Size(1205, 687);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox txtAddEmpAccountType;
        private System.Windows.Forms.DateTimePicker joinEmployeeDateTimePicker;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddEmpQaulification;
        private System.Windows.Forms.TextBox txtAddEmpAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddEmpSalary;
        private System.Windows.Forms.DataGridView EmployeedataGridView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmployeeDeletSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddNameEmp;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MaskedTextBox txtAddPhoneEmp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
