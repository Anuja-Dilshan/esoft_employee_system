namespace esoft_employee_system
{
    partial class frmEmployeeOps
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
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            btnSearch = new Button();
            btnViewemps = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 25);
            label1.Name = "label1";
            label1.Size = new Size(235, 38);
            label1.TabIndex = 0;
            label1.Text = "Select Operation";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Blue;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(245, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(278, 52);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add New Employee";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Blue;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(245, 187);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(278, 52);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update Existing Employee";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Blue;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(245, 268);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(278, 52);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete Existing Employee";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaptionText;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(275, 577);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(185, 60);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Blue;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(245, 349);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(278, 52);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search Employee";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnViewemps
            // 
            btnViewemps.BackColor = Color.Blue;
            btnViewemps.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewemps.ForeColor = SystemColors.Control;
            btnViewemps.Location = new Point(245, 435);
            btnViewemps.Name = "btnViewemps";
            btnViewemps.Size = new Size(278, 52);
            btnViewemps.TabIndex = 1;
            btnViewemps.Text = "View All Employees\r\n";
            btnViewemps.UseVisualStyleBackColor = false;
            btnViewemps.Click += btnViewemps_Click;
            // 
            // frmEmployeeOps
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 666);
            Controls.Add(btnBack);
            Controls.Add(btnViewemps);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            MinimumSize = new Size(819, 696);
            Name = "frmEmployeeOps";
            Text = "GRIFINDOR - EMPLOYEE OPERATIONS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack;
        private Button btnSearch;
        private Button btnViewemps;
    }
}