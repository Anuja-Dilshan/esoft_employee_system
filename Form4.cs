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

namespace esoft_employee_system
{

    public partial class frmSalary : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=ANUJA-DILSHAN\\SQLEXPRESS;Initial Catalog=employee_management_system;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        DateTime cycle_start;
        DateTime cycle_end;
        int salary_date_range;
        int accepted_num_leaves;
        int leaves_taken; 
        public frmSalary()
        {
            InitializeComponent();
        }

        private void frmSalary_Load(object sender, EventArgs e)
        {
            fill_combobox();
            get_salary_info();
        }

        private void fill_combobox()
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
        private void get_salary_info()
        {
            string query = "SELECT * FROM salary_info";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cycle_start = Convert.ToDateTime(reader["cycle_start_date"]);
                    cycle_end = Convert.ToDateTime(reader["cycle_end_date"]);
                    accepted_num_leaves = Convert.ToInt32(reader["num_of_leaves"]);
                    salary_date_range = Convert.ToInt32(reader["salary_date_range"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }

        private bool check_entered_data()
        {
            //if(Convert.ToInt32(txtnumofleaves.Text) > accepted_num_leaves)
            //{
            //    MessageBox.Show("The employee has exceeded accepted no. of leaves","Leaves count exceeded!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //}
            leaves_taken = Convert.ToInt32(txtnumofleaves.Text);
            if (leaves_taken > salary_date_range)
            {
                MessageBox.Show("Leave count cannot exceed the total working days", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnumofleaves.Clear();
                return false;
            }
            return true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmMain main_pg = new frmMain();
            this.Hide();
            main_pg.ShowDialog();
        }
    }
}
