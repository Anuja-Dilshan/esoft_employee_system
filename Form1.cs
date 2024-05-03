using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections.Generic;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace esoft_employee_system
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=ANUJA-DILSHAN\\SQLEXPRESS;Initial Catalog=employee_management_system;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        bool show_password;
        public Form1()
        {
            InitializeComponent();
        }





        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (authentication())
            {
                frmMain main_form = new frmMain();
                this.Hide();
                main_form.user_name = txtUsername.Text;
                main_form.password = txtPassword.Text;
                main_form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect User Name or Password", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            this.Close();
        }

        private bool authentication()
        {
            List<string> usernames = new List<string>();
            List<string> passwords = new List<string>();

            string query = "SELECT user_name, password FROM logging_details";
            SqlCommand cmd = new SqlCommand(query, conn);


            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string username = reader.GetString(0);
                    string password = reader.GetString(1);

                    // Add username and password to respective lists
                    usernames.Add(username);
                    passwords.Add(password);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }

            for (int i = 0; i < usernames.Count; i++)
            {
                if (txtUsername.Text == usernames[i])
                {
                    if (txtPassword.Text == passwords[i])
                    {
                        return true;
                    }
                    return false;
                }

            }
            return false;

        }

        private void checkshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkshowpass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }

            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlmain.BackColor = Color.FromArgb(100,0,0, 0);
        }

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkshowpass.Checked == true)
        //    {
        //        txtPassword.UseSystemPasswordChar = false;
        //    }
        //    else
        //    {
        //        txtPassword.UseSystemPasswordChar = true;
        //    }
        //}

        //private void panel2_Paint(object sender, PaintEventArgs e)
        //{
        //    txtPassword.PasswordChar = '.';
        //}

        //private void txtPassword_MouseHover(object sender, EventArgs e)
        //{
        //    if (checkshowpass.Checked == true)
        //    {
        //        txtPassword.PasswordChar = '\0';
        //    }
        //    else
        //    {
        //        txtPassword.PasswordChar = '.';
        //    }
        //}

        //private void txtPassword_MouseLeave(object sender, EventArgs e)
        //{
        //    if (checkshowpass.Checked == true)
        //    {
        //        txtPassword.PasswordChar = '\0';
        //    }
        //    else
        //    {
        //        txtPassword.PasswordChar = '.';
        //    }
        //}

        //private void txtPassword_MouseEnter(object sender, EventArgs e)
        //{
        //    if (checkshowpass.Checked == true)
        //    {
        //        txtPassword.PasswordChar = '\0';
        //    }
        //    else
        //    {
        //        txtPassword.PasswordChar = '.';
        //    }
        //}

        //private void txtPassword_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (checkshowpass.Checked == true)
        //    {
        //        txtPassword.PasswordChar = '\0';
        //    }
        //    else
        //    {
        //        txtPassword.PasswordChar = '.';
        //    }
        //}

        //private void txtPassword_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (checkshowpass.Checked == true)
        //    {
        //        txtPassword.PasswordChar = '\0';
        //    }
        //    else
        //    {
        //        txtPassword.PasswordChar = '.';
        //    }
        //}

        //private void txtPassword_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (checkshowpass.Checked == true)
        //    {
        //        txtPassword.PasswordChar = '\0';
        //    }
        //    else
        //    {
        //        txtPassword.PasswordChar = '.';
        //    }
        //}
    }


}
