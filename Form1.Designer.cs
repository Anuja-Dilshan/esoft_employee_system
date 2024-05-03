namespace esoft_employee_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pnlmain = new Panel();
            lblusername = new Label();
            checkshowpass = new CheckBox();
            txtUsername = new TextBox();
            lblpassword = new Label();
            txtPassword = new TextBox();
            btnCancel = new Button();
            btnLogin = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlmain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 44);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(429, 3);
            label1.Name = "label1";
            label1.Size = new Size(184, 41);
            label1.TabIndex = 0;
            label1.Text = "GRIFINDOR";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackgroundImage = Properties.Resources.Default_Grifindor_toys_colourful_factory_servants_joyful_happi_3;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pnlmain);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnLogin);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1086, 644);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pnlmain
            // 
            pnlmain.Anchor = AnchorStyles.None;
            pnlmain.BackColor = Color.White;
            pnlmain.Controls.Add(lblusername);
            pnlmain.Controls.Add(checkshowpass);
            pnlmain.Controls.Add(txtUsername);
            pnlmain.Controls.Add(lblpassword);
            pnlmain.Controls.Add(txtPassword);
            pnlmain.Location = new Point(154, 57);
            pnlmain.Name = "pnlmain";
            pnlmain.Size = new Size(786, 453);
            pnlmain.TabIndex = 16;
            // 
            // lblusername
            // 
            lblusername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.Transparent;
            lblusername.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.ForeColor = Color.DarkGray;
            lblusername.Location = new Point(293, 73);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(139, 31);
            lblusername.TabIndex = 0;
            lblusername.Text = "USERNAME";
            // 
            // checkshowpass
            // 
            checkshowpass.AutoSize = true;
            checkshowpass.BackColor = Color.Transparent;
            checkshowpass.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkshowpass.ForeColor = Color.DarkGray;
            checkshowpass.Location = new Point(554, 324);
            checkshowpass.Name = "checkshowpass";
            checkshowpass.Size = new Size(165, 29);
            checkshowpass.TabIndex = 15;
            checkshowpass.Text = "Show Password";
            checkshowpass.UseVisualStyleBackColor = false;
            checkshowpass.CheckedChanged += checkshowpass_CheckedChanged;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(220, 133);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(311, 34);
            txtUsername.TabIndex = 1;
            // 
            // lblpassword
            // 
            lblpassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblpassword.AutoSize = true;
            lblpassword.BackColor = Color.Transparent;
            lblpassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.ForeColor = Color.DarkGray;
            lblpassword.Location = new Point(291, 256);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(141, 31);
            lblpassword.TabIndex = 0;
            lblpassword.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(220, 319);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(311, 34);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Black;
            btnCancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(904, 576);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 50);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogin.BackColor = SystemColors.ActiveCaptionText;
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(13, 576);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 50);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 688);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(778, 497);
            Name = "Form1";
            Text = "GRIFINDOR - LOGIN";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            pnlmain.ResumeLayout(false);
            pnlmain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblpassword;
        private Label lblusername;
        private Button btnCancel;
        private CheckBox checkshowpass;
        private Panel pnlmain;
    }
}
