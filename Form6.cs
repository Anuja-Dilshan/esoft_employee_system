using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace esoft_employee_system
{
    public partial class frmupdateemp : Form

    {
        public bool update_1 { get; set; }
        public bool delete_1 { get; set; }



        public bool search_1 { get; set; }
        SqlConnection conn = new SqlConnection("Data Source=ANUJA-DILSHAN\\SQLEXPRESS;Initial Catalog=employee_management_system;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

        public frmupdateemp()
        {
            InitializeComponent();

        }



        private void frmupdateemp_Load(object sender, EventArgs e)
        {
            fill_combobox_dropdown();
           
            if (update_1 == true && search_1 == false && delete_1 == false)
            {
                lblheading.Text = "UPDATE EMPLOYEE DETAILS";
            }
            else if (search_1 == true && delete_1 == false && update_1 == false)
            {
                lblheading.Text = "SEARCH EMPLOYEE DETAILS";
            }
            else if (delete_1 == true && update_1 == false && search_1 == false)
            {
                lblheading.Text = "DELETE EMPLOYEE DETAILS";
            }

        }

        private void fill_combobox_dropdown()
        {
            cmbemployeeid.Items.Clear();


            string pos_query = "SELECT EmployeeNo FROM Employees_New2";
            SqlCommand cmd = new SqlCommand(pos_query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbemployeeid.Items.Add("EMP" + dr["EmployeeNo"].ToString());
            }
            conn.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                frmupdatingmainpg updatingpg = new frmupdatingmainpg();
                
                updatingpg.employeeid = cmbemployeeid.Text.Substring(3);
                if (update_1 == true && search_1 == false && delete_1 == false)
                {
                    updatingpg.update = true;
                    updatingpg.delete = false;
                    updatingpg.search = false;
                }
                else if (update_1 == false && search_1 == true && delete_1 == false)
                {
                    updatingpg.search = true;
                    updatingpg.update = false;
                    updatingpg.delete = false;
                }
                else if (update_1 == false && search_1 == false && delete_1 == true)
                {
                    updatingpg.delete = true;
                    updatingpg.search = false;
                    updatingpg.update = false;
                }
                //Console.WriteLine($"update_1:{update_1},search_1:{search_1},delete_1:{delete_1}");
                this.Close();
                updatingpg.Show();

            }
            else
            {
                MessageBox.Show("Incorrect Emploee ID", "ID not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool validate_data()
        {
            string regex = @"^EMP\d+$";

            if (Regex.IsMatch(cmbemployeeid.Text, regex))
            {
                string query = "SELECT COUNT(*) FROM Employees_New2 WHERE EmployeeNo = @employeeno";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@employeeno", cmbemployeeid.Text.Substring(3));
                conn.Open();
                int i = (int)cmd.ExecuteScalar();
                if (i > 0)
                {
                    conn.Close();
                    return true;
                }
                conn.Close();
                return false;
            }
            else
            {
                MessageBox.Show("ID should start with EMP and then the ID number", "Incorrect ID pattern", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmEmployeeOps frmOps = new frmEmployeeOps();
            this.Hide();
            frmOps.Show();
        }

        //private void frmupdateemp_VisibleChanged(object sender, EventArgs e)
        //{

        //    if (this.Visible)
        //    {
        //        frmupdateemp_Load(sender,e);
        //    }
            
        //}

       
    }


}
