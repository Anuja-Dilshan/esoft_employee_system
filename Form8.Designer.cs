namespace esoft_employee_system
{
    partial class frmsettings
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
            lblrange = new Label();
            label3 = new Label();
            label4 = new Label();
            datepickerstartdate = new DateTimePicker();
            datepickerenddate = new DateTimePicker();
            label5 = new Label();
            txtannumleaves = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            cmbdaterange = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 140);
            label1.Name = "label1";
            label1.Size = new Size(271, 31);
            label1.TabIndex = 0;
            label1.Text = "Salary cycle date range: ";
            // 
            // lblrange
            // 
            lblrange.AutoSize = true;
            lblrange.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblrange.Location = new Point(661, 157);
            lblrange.Name = "lblrange";
            lblrange.Size = new Size(175, 28);
            lblrange.TabIndex = 2;
            lblrange.Text = "Selected range: 7";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 271);
            label3.Name = "label3";
            label3.Size = new Size(272, 31);
            label3.TabIndex = 2;
            label3.Text = "Salary Cycle Begin Date:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(80, 405);
            label4.Name = "label4";
            label4.Size = new Size(250, 31);
            label4.TabIndex = 2;
            label4.Text = "Salary Cycle End Date:";
            // 
            // datepickerstartdate
            // 
            datepickerstartdate.Location = new Point(362, 275);
            datepickerstartdate.Name = "datepickerstartdate";
            datepickerstartdate.Size = new Size(250, 27);
            datepickerstartdate.TabIndex = 3;
            datepickerstartdate.ValueChanged += datepickerstartdate_ValueChanged;
            // 
            // datepickerenddate
            // 
            datepickerenddate.Location = new Point(362, 405);
            datepickerenddate.Name = "datepickerenddate";
            datepickerenddate.Size = new Size(250, 27);
            datepickerenddate.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 543);
            label5.Name = "label5";
            label5.Size = new Size(280, 31);
            label5.TabIndex = 5;
            label5.Text = "No. of leaves per annum:";
            // 
            // txtannumleaves
            // 
            txtannumleaves.Location = new Point(362, 543);
            txtannumleaves.Multiline = true;
            txtannumleaves.Name = "txtannumleaves";
            txtannumleaves.Size = new Size(250, 31);
            txtannumleaves.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(107, 733);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(178, 71);
            btnSave.TabIndex = 7;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(860, 733);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(178, 71);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "BACK";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbdaterange
            // 
            cmbdaterange.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbdaterange.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbdaterange.FormattingEnabled = true;
            cmbdaterange.Items.AddRange(new object[] { "7", "15", "28", "29", "30" });
            cmbdaterange.Location = new Point(360, 152);
            cmbdaterange.Name = "cmbdaterange";
            cmbdaterange.Size = new Size(252, 33);
            cmbdaterange.TabIndex = 8;
            cmbdaterange.SelectedIndexChanged += cmbdaterange_SelectedIndexChanged;
            // 
            // frmsettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 862);
            Controls.Add(cmbdaterange);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtannumleaves);
            Controls.Add(label5);
            Controls.Add(datepickerenddate);
            Controls.Add(datepickerstartdate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblrange);
            Controls.Add(label1);
            Name = "frmsettings";
            Text = "GRIFINDOR - SETTINGS";
            Load += frmsettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblrange;
        private Label label3;
        private Label label4;
        private DateTimePicker datepickerstartdate;
        private DateTimePicker datepickerenddate;
        private Label label5;
        private TextBox txtannumleaves;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cmbdaterange;
    }
}