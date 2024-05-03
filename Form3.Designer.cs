namespace esoft_employee_system
{
    partial class frmEmployee
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            label7 = new Label();
            txtLastName = new TextBox();
            label8 = new Label();
            lblEmployeeNo = new Label();
            txtMonthlySalary = new TextBox();
            txtOvertimerate = new TextBox();
            label10 = new Label();
            txtAllowances = new TextBox();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            btnBack = new Button();
            btnADD = new Button();
            label9 = new Label();
            radiobtnMale = new RadioButton();
            radiobtnfemale = new RadioButton();
            radiobtnother = new RadioButton();
            label12 = new Label();
            txtAddress = new TextBox();
            label13 = new Label();
            txtContactNo = new TextBox();
            label14 = new Label();
            cmbposition = new ComboBox();
            btnCancel = new Button();
            label15 = new Label();
            txtNICNo = new TextBox();
            label16 = new Label();
            label17 = new Label();
            txtCity = new TextBox();
            cmbDisctricts = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(482, 60);
            label1.Name = "label1";
            label1.Size = new Size(273, 38);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEE DETAILS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 144);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 1;
            label2.Text = "Employee No:  ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 358);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 1;
            label3.Text = "First Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(113, 621);
            label4.Name = "label4";
            label4.Size = new Size(122, 28);
            label4.TabIndex = 1;
            label4.Text = "Birth Date: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(84, 439);
            label5.Name = "label5";
            label5.Size = new Size(151, 28);
            label5.TabIndex = 1;
            label5.Text = "Middle Name: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(670, 623);
            label6.Name = "label6";
            label6.Size = new Size(209, 28);
            label6.TabIndex = 1;
            label6.Text = "Monthly Salary (Rs.):";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(287, 623);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(273, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(287, 352);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(273, 34);
            txtFirstName.TabIndex = 3;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(287, 433);
            txtMiddleName.Multiline = true;
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(273, 34);
            txtMiddleName.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(112, 527);
            label7.Name = "label7";
            label7.Size = new Size(123, 28);
            label7.TabIndex = 1;
            label7.Text = "Last Name: ";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(287, 521);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(273, 34);
            txtLastName.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(606, 702);
            label8.Name = "label8";
            label8.Size = new Size(273, 28);
            label8.TabIndex = 1;
            label8.Text = "Overtime rates hourly (Rs.):";
            // 
            // lblEmployeeNo
            // 
            lblEmployeeNo.AutoSize = true;
            lblEmployeeNo.Location = new Point(287, 152);
            lblEmployeeNo.Name = "lblEmployeeNo";
            lblEmployeeNo.Size = new Size(50, 20);
            lblEmployeeNo.TabIndex = 4;
            lblEmployeeNo.Text = "label9";
            // 
            // txtMonthlySalary
            // 
            txtMonthlySalary.Location = new Point(920, 615);
            txtMonthlySalary.Multiline = true;
            txtMonthlySalary.Name = "txtMonthlySalary";
            txtMonthlySalary.Size = new Size(273, 34);
            txtMonthlySalary.TabIndex = 3;
            // 
            // txtOvertimerate
            // 
            txtOvertimerate.Location = new Point(920, 696);
            txtOvertimerate.Multiline = true;
            txtOvertimerate.Name = "txtOvertimerate";
            txtOvertimerate.Size = new Size(273, 34);
            txtOvertimerate.TabIndex = 3;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(708, 780);
            label10.Name = "label10";
            label10.Size = new Size(171, 28);
            label10.TabIndex = 1;
            label10.Text = "Allowances (Rs.):";
            // 
            // txtAllowances
            // 
            txtAllowances.Anchor = AnchorStyles.None;
            txtAllowances.Location = new Point(920, 774);
            txtAllowances.Multiline = true;
            txtAllowances.Name = "txtAllowances";
            txtAllowances.Size = new Size(273, 34);
            txtAllowances.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(66, 222);
            label11.Name = "label11";
            label11.Size = new Size(169, 28);
            label11.TabIndex = 1;
            label11.Text = "Registered Date:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Enabled = false;
            dateTimePicker2.ImeMode = ImeMode.NoControl;
            dateTimePicker2.Location = new Point(287, 224);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(273, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.BackColor = Color.Black;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(920, 914);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(163, 73);
            btnBack.TabIndex = 5;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnADD
            // 
            btnADD.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnADD.BackColor = Color.Black;
            btnADD.Enabled = false;
            btnADD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnADD.ForeColor = Color.White;
            btnADD.Location = new Point(197, 914);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(163, 73);
            btnADD.TabIndex = 5;
            btnADD.Text = "ADD";
            btnADD.UseVisualStyleBackColor = false;
            btnADD.Click += btnADD_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(142, 285);
            label9.Name = "label9";
            label9.Size = new Size(86, 28);
            label9.TabIndex = 6;
            label9.Text = "Gender:";
            // 
            // radiobtnMale
            // 
            radiobtnMale.AutoSize = true;
            radiobtnMale.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radiobtnMale.Location = new Point(296, 290);
            radiobtnMale.Name = "radiobtnMale";
            radiobtnMale.Size = new Size(64, 24);
            radiobtnMale.TabIndex = 7;
            radiobtnMale.TabStop = true;
            radiobtnMale.Text = "Male";
            radiobtnMale.UseVisualStyleBackColor = true;
            // 
            // radiobtnfemale
            // 
            radiobtnfemale.AutoSize = true;
            radiobtnfemale.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radiobtnfemale.Location = new Point(411, 290);
            radiobtnfemale.Name = "radiobtnfemale";
            radiobtnfemale.Size = new Size(80, 24);
            radiobtnfemale.TabIndex = 8;
            radiobtnfemale.TabStop = true;
            radiobtnfemale.Text = "Female";
            radiobtnfemale.UseVisualStyleBackColor = true;
            // 
            // radiobtnother
            // 
            radiobtnother.AutoSize = true;
            radiobtnother.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radiobtnother.Location = new Point(527, 290);
            radiobtnother.Name = "radiobtnother";
            radiobtnother.Size = new Size(70, 24);
            radiobtnother.TabIndex = 9;
            radiobtnother.TabStop = true;
            radiobtnother.Text = "Other";
            radiobtnother.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(786, 222);
            label12.Name = "label12";
            label12.Size = new Size(92, 28);
            label12.TabIndex = 10;
            label12.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(920, 217);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(273, 96);
            txtAddress.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.Location = new Point(111, 798);
            label13.Name = "label13";
            label13.Size = new Size(124, 28);
            label13.TabIndex = 12;
            label13.Text = "Contact No:";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(287, 798);
            txtContactNo.Multiline = true;
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(273, 34);
            txtContactNo.TabIndex = 11;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.Location = new Point(786, 546);
            label14.Name = "label14";
            label14.Size = new Size(93, 28);
            label14.TabIndex = 13;
            label14.Text = "Position:";
            // 
            // cmbposition
            // 
            cmbposition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbposition.FormattingEnabled = true;
            cmbposition.Location = new Point(920, 546);
            cmbposition.Name = "cmbposition";
            cmbposition.Size = new Size(273, 28);
            cmbposition.TabIndex = 14;
            cmbposition.SelectedIndexChanged += cmbposition_SelectedIndexChanged;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.BackColor = Color.Black;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(557, 914);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(163, 73);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.Location = new Point(123, 710);
            label15.Name = "label15";
            label15.Size = new Size(85, 28);
            label15.TabIndex = 16;
            label15.Text = "NIC No:";
            // 
            // txtNICNo
            // 
            txtNICNo.Location = new Point(287, 714);
            txtNICNo.Multiline = true;
            txtNICNo.Name = "txtNICNo";
            txtNICNo.Size = new Size(273, 34);
            txtNICNo.TabIndex = 17;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label16.Location = new Point(824, 368);
            label16.Name = "label16";
            label16.Size = new Size(54, 28);
            label16.TabIndex = 18;
            label16.Text = "City:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label17.Location = new Point(792, 456);
            label17.Name = "label17";
            label17.Size = new Size(87, 28);
            label17.TabIndex = 18;
            label17.Text = "District:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(920, 368);
            txtCity.Multiline = true;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(273, 34);
            txtCity.TabIndex = 19;
            // 
            // cmbDisctricts
            // 
            cmbDisctricts.AutoCompleteCustomSource.AddRange(new string[] { "Ampara", "Anuradhapura", "Badulla", "Batticaloa", "Colombo", "Galle", "Gampaha", "Hambantota", "Jaffna", "Kalutara", "Kandy", "Kegalle", "Kilinochchi", "Kurunegala", "Mannar", "Matale", "Matara", "Monaragala", "Mullaitivu", "Nuwara Eliya", "Polonnaruwa", "Puttalam", "Ratnapura", "Trincomalee", "Vavuniya" });
            cmbDisctricts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbDisctricts.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDisctricts.FormattingEnabled = true;
            cmbDisctricts.Items.AddRange(new object[] { "Ampara", "Anuradhapura", "Badulla", "Batticaloa", "Colombo", "Galle", "Gampaha", "Hambantota", "Jaffna", "Kalutara", "Kandy", "Kegalle", "Kilinochchi", "Kurunegala", "Mannar", "Matale", "Matara", "Monaragala", "Mullaitivu", "Nuwara Eliya", "Polonnaruwa", "Puttalam", "Ratnapura", "Trincomalee", "Vavuniya" });
            cmbDisctricts.Location = new Point(920, 456);
            cmbDisctricts.Name = "cmbDisctricts";
            cmbDisctricts.Size = new Size(273, 28);
            cmbDisctricts.TabIndex = 20;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 1055);
            Controls.Add(cmbDisctricts);
            Controls.Add(txtCity);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(txtNICNo);
            Controls.Add(label15);
            Controls.Add(btnCancel);
            Controls.Add(cmbposition);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(txtContactNo);
            Controls.Add(txtAddress);
            Controls.Add(label12);
            Controls.Add(radiobtnother);
            Controls.Add(radiobtnfemale);
            Controls.Add(radiobtnMale);
            Controls.Add(label9);
            Controls.Add(btnBack);
            Controls.Add(btnADD);
            Controls.Add(lblEmployeeNo);
            Controls.Add(txtAllowances);
            Controls.Add(txtOvertimerate);
            Controls.Add(txtMonthlySalary);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(1324, 819);
            Name = "frmEmployee";
            Text = "GRIFINDOR - NEW EMPLOYEE";
            Load += frmEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private Label label7;
        private TextBox txtLastName;
        private Label label8;
        private Label lblEmployeeNo;
        private TextBox txtMonthlySalary;
        private TextBox txtOvertimerate;
        private Label label10;
        private TextBox txtAllowances;
        private Label label11;
        private DateTimePicker dateTimePicker2;
        private Button btnBack;
        private Button btnADD;
        private Label label9;
        private RadioButton radiobtnMale;
        private RadioButton radiobtnfemale;
        private RadioButton radiobtnother;
        private Label label12;
        private TextBox txtAddress;
        private Label label13;
        private TextBox txtContactNo;
        private Label label14;
        private ComboBox cmbposition;
        private Button btnCancel;
        private Label label15;
        private TextBox txtNICNo;
        private Label label16;
        private Label label17;
        private TextBox txtCity;
        private ComboBox cmbDisctricts;
    }
}