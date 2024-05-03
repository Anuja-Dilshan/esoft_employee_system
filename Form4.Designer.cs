namespace esoft_employee_system
{
    partial class frmSalary
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
            cmbemployeeid = new ComboBox();
            btnback = new Button();
            datetimepicker_begin_date = new DateTimePicker();
            dateTimePicker_end_date = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtnumofleaves = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(562, 9);
            label1.Name = "label1";
            label1.Size = new Size(344, 50);
            label1.TabIndex = 0;
            label1.Text = "Salary Component";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 151);
            label2.Name = "label2";
            label2.Size = new Size(154, 31);
            label2.TabIndex = 1;
            label2.Text = "Employee ID:";
            // 
            // cmbemployeeid
            // 
            cmbemployeeid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbemployeeid.FormattingEnabled = true;
            cmbemployeeid.Location = new Point(172, 151);
            cmbemployeeid.Name = "cmbemployeeid";
            cmbemployeeid.Size = new Size(190, 28);
            cmbemployeeid.TabIndex = 2;
            // 
            // btnback
            // 
            btnback.BackColor = Color.Black;
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.ForeColor = Color.White;
            btnback.Location = new Point(562, 764);
            btnback.Name = "btnback";
            btnback.Size = new Size(165, 56);
            btnback.TabIndex = 3;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // datetimepicker_begin_date
            // 
            datetimepicker_begin_date.Enabled = false;
            datetimepicker_begin_date.Location = new Point(634, 155);
            datetimepicker_begin_date.Name = "datetimepicker_begin_date";
            datetimepicker_begin_date.Size = new Size(250, 27);
            datetimepicker_begin_date.TabIndex = 4;
            // 
            // dateTimePicker_end_date
            // 
            dateTimePicker_end_date.Enabled = false;
            dateTimePicker_end_date.Location = new Point(1129, 155);
            dateTimePicker_end_date.Name = "dateTimePicker_end_date";
            dateTimePicker_end_date.Size = new Size(250, 27);
            dateTimePicker_end_date.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(428, 151);
            label3.Name = "label3";
            label3.Size = new Size(200, 31);
            label3.TabIndex = 1;
            label3.Text = "Cycle Begin Date:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(951, 151);
            label4.Name = "label4";
            label4.Size = new Size(178, 31);
            label4.TabIndex = 1;
            label4.Text = "Cycle End Date:\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 253);
            label5.Name = "label5";
            label5.Size = new Size(224, 31);
            label5.TabIndex = 1;
            label5.Text = "No. of leaves taken:";
            // 
            // txtnumofleaves
            // 
            txtnumofleaves.Location = new Point(242, 257);
            txtnumofleaves.Multiline = true;
            txtnumofleaves.Name = "txtnumofleaves";
            txtnumofleaves.Size = new Size(190, 27);
            txtnumofleaves.TabIndex = 5;
            // 
            // frmSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1391, 832);
            Controls.Add(txtnumofleaves);
            Controls.Add(dateTimePicker_end_date);
            Controls.Add(datetimepicker_begin_date);
            Controls.Add(btnback);
            Controls.Add(cmbemployeeid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSalary";
            Text = "GRIFINDOR - SALARY";
            Load += frmSalary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbemployeeid;
        private Button btnback;
        private DateTimePicker datetimepicker_begin_date;
        private DateTimePicker dateTimePicker_end_date;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtnumofleaves;
    }
}