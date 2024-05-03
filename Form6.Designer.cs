namespace esoft_employee_system
{
    partial class frmupdateemp
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
            lblheading = new Label();
            label2 = new Label();
            cmbemployeeid = new ComboBox();
            btnEnter = new Button();
            btnback = new Button();
            SuspendLayout();
            // 
            // lblheading
            // 
            lblheading.Anchor = AnchorStyles.Top;
            lblheading.AutoSize = true;
            lblheading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblheading.Location = new Point(342, 9);
            lblheading.Name = "lblheading";
            lblheading.Size = new Size(415, 41);
            lblheading.TabIndex = 0;
            lblheading.Text = "UPDATE EMPLOYEE DETAILS";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 331);
            label2.Name = "label2";
            label2.Size = new Size(496, 38);
            label2.TabIndex = 1;
            label2.Text = "Please enter the ID of the employee:";
            // 
            // cmbemployeeid
            // 
            cmbemployeeid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbemployeeid.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbemployeeid.FormattingEnabled = true;
            cmbemployeeid.Location = new Point(514, 341);
            cmbemployeeid.Name = "cmbemployeeid";
            cmbemployeeid.Size = new Size(192, 28);
            cmbemployeeid.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Black;
            btnEnter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(776, 315);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(166, 54);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnback
            // 
            btnback.BackColor = Color.Black;
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnback.ForeColor = Color.White;
            btnback.Location = new Point(776, 510);
            btnback.Name = "btnback";
            btnback.Size = new Size(166, 54);
            btnback.TabIndex = 4;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // frmupdateemp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 723);
            Controls.Add(btnback);
            Controls.Add(btnEnter);
            Controls.Add(cmbemployeeid);
            Controls.Add(label2);
            Controls.Add(lblheading);
            Name = "frmupdateemp";
            Text = "GRIFINDOR - UPDATE EMPLOYEES";
            Load += frmupdateemp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblheading;
        private Label label2;
        private ComboBox cmbemployeeid;
        private Button btnEnter;
        private Button btnback;
    }
}