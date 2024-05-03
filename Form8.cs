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
    public partial class frmsettings : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=ANUJA-DILSHAN\\SQLEXPRESS;Initial Catalog=employee_management_system;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

        public frmsettings()
        {
            InitializeComponent();
        }

        private void frmsettings_Load(object sender, EventArgs e)
        {
            DateTime start_date;
            DateTime end_date;
            //if (int.TryParse(cmbdaterange.Text, out parsed))
            //{

            //}
            //int salary_date_range =Convert.ToInt32(cmbdaterange.Text);
            string query = "SELECT * FROM salary_info";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cmbdaterange.Text = reader["salary_date_range"].ToString();
                    txtannumleaves.Text = reader["num_of_leaves"].ToString();
                    if (DateTime.TryParse(reader["cycle_start_date"].ToString(), out start_date))
                    {
                        datepickerstartdate.Value = start_date;
                    }
                    if (DateTime.TryParse(reader["cycle_end_date"].ToString(), out end_date))
                    {
                        datepickerenddate.Value = end_date;
                    }
                }

                lblrange.Text = $"Selected range: {cmbdaterange.Text}";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                string query = "UPDATE salary_info SET salary_date_range=@daterange, cycle_start_date=@cyclestart, cycle_end_date=@cycleend, num_of_leaves=@annualleaves";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@daterange", cmbdaterange.Text);
                cmd.Parameters.AddWithValue("@cyclestart", datepickerstartdate.Value);
                cmd.Parameters.AddWithValue("@cycleend", datepickerenddate.Value);
                cmd.Parameters.AddWithValue("@annualleaves", txtannumleaves.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("New settings updates successfully", "Settings Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void datepickerstartdate_ValueChanged(object sender, EventArgs e)
        {
            datepickerenddate.Value = datepickerstartdate.Value.AddDays(Convert.ToInt32(cmbdaterange.Text));
        }

        private bool validate_data()
        {
            string regex = @"^([1][0-9]|[2][0-9]|30)$";
            if (Convert.ToInt32(txtannumleaves.Text) == 0 || txtannumleaves == null)
            {
                MessageBox.Show("Annual leave count cannot be null or 0", "Invalid data ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            else if (!int.TryParse(txtannumleaves.Text, out int num))
            {
                MessageBox.Show("The annual leave count should be a number");
                return false;
            }
            else if (!Regex.IsMatch(txtannumleaves.Text, regex))
            {
                MessageBox.Show("The annual leave count should be between 10 and 30", "Exceeds the limit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (cmbdaterange.Text == "30" && datepickerstartdate.Value.Month==2)
            {
                MessageBox.Show("February doesn't have 30 days","Incorrect Data",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (cmbdaterange.Text=="29" && datepickerstartdate.Value.Month == 2 && !Isleapyear())
            {
                MessageBox.Show($"{datepickerstartdate.Value.Year} is not a leap year", "Incorrect Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool Isleapyear()
        {
            if (DateTime.IsLeapYear(datepickerstartdate.Value.Year))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cmbdaterange_SelectedIndexChanged(object sender, EventArgs e)
        {
            datepickerenddate.Value = datepickerstartdate.Value.AddDays(Convert.ToInt32(cmbdaterange.Text));
            lblrange.Text = $"Selected range: {cmbdaterange.Text}";


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMain main_pg = new frmMain();
            this.Close();
            main_pg.ShowDialog();
        }
    }

}
