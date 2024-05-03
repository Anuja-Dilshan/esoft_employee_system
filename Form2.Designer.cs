namespace esoft_employee_system
{
    partial class frmMain
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
            btnEmployee = new Button();
            btnSalary = new Button();
            btnSettings = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 46);
            label1.Name = "label1";
            label1.Size = new Size(184, 41);
            label1.TabIndex = 0;
            label1.Text = "GRIFINDOR";
            label1.Click += label1_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Anchor = AnchorStyles.None;
            btnEmployee.AutoSize = true;
            btnEmployee.BackColor = Color.Black;
            btnEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = Color.White;
            btnEmployee.Location = new Point(306, 134);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(148, 46);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "Employees";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnSalary
            // 
            btnSalary.Anchor = AnchorStyles.None;
            btnSalary.BackColor = Color.Black;
            btnSalary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalary.ForeColor = Color.White;
            btnSalary.Location = new Point(306, 227);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(148, 46);
            btnSalary.TabIndex = 2;
            btnSalary.Text = "Salary";
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += btnSalary_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.None;
            btnSettings.BackColor = Color.Black;
            btnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(306, 322);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(148, 46);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 450);
            Controls.Add(btnSettings);
            Controls.Add(btnSalary);
            Controls.Add(btnEmployee);
            Controls.Add(label1);
            MinimumSize = new Size(795, 497);
            Name = "frmMain";
            Text = "GRIFINDOR - MAIN PAGE";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEmployee;
        private Button btnSalary;
        private Button btnSettings;
    }
}