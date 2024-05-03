using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Collections;
using System.Data.Common;
using System.Text.RegularExpressions;


namespace esoft_employee_system
{
    public partial class frmEmployee : Form
    {
        //public string connectionstring = "Data Source=ANUJA-DILSHAN\\SQLEXPRESS;Initial Catalog=employee_management_system;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        SqlConnection conn = new SqlConnection("Data Source=ANUJA-DILSHAN\\SQLEXPRESS;Initial Catalog=employee_management_system;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

        //public int employee_reg_no = 1;
        public string gender;

        public frmEmployee()
        {
            InitializeComponent();
        }


        private void frmEmployee_Load(object sender, EventArgs e)
        {

            
            load_emp_id();
            dateTimePicker2.Value = DateTime.Today;
        
            fillcmbboxdropdown();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmEmployeeOps employee_ops = new frmEmployeeOps();
            this.Hide();
            employee_ops.ShowDialog();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {

            if (!null_data_checker())
            {
                if (radiobtnfemale.Checked == true)
                {
                    gender = "female";
                }
                else if (radiobtnMale.Checked == true)
                {
                    gender = "male";
                }
                else
                {
                    gender = "other";
                }
                if (validate_numbers() && validate_nic() == true)
                {

                    try
                    {
                        if (isRecordDuplicate())
                        {
                            MessageBox.Show("Record already exists", "Duplicate Record Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        insert_record();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();

                    }

                }


            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int date_compare = DateTime.Compare(dateTimePicker1.Value, dateTimePicker2.Value);
            if (date_compare == 0 || date_compare > 0)
            {
                MessageBox.Show("Birthday can't be after registering date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnADD.Enabled = false;
                btnADD.ForeColor = Color.White;


            }
            else
            {
                var diff_of_dates = dateTimePicker2.Value.Subtract(dateTimePicker1.Value);
                if (diff_of_dates.Days < 6575)
                {
                    MessageBox.Show("Your are UNDER AGED. You must be atleast 18 years old", "Age requirement not satisfied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnADD.Enabled = false;
                    btnADD.ForeColor = Color.White;
                }
                else
                {
                    btnADD.Enabled = true;
                }
            }
        }

        private bool null_data_checker()//check for null data
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtMonthlySalary.Text) || string.IsNullOrEmpty(txtOvertimerate.Text) || string.IsNullOrEmpty(txtAllowances.Text) || string.IsNullOrEmpty(txtContactNo.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtNICNo.Text) || string.IsNullOrEmpty(txtCity.Text)||string.IsNullOrEmpty(cmbDisctricts.Text)||string.IsNullOrEmpty(cmbposition.Text))
            {
                MessageBox.Show("You cant keep null data", "Null Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //btnADD.Enabled = false;
                return true;
            }
            else if (radiobtnfemale.Checked == false && radiobtnMale.Checked == false && radiobtnother.Checked == false)
            {
                MessageBox.Show("Please select Male, Female or other", "Missing Gender", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //btnADD.Enabled = false;
                return true;

            }
            else
            {
                return false;
            }
        }


        private bool validate_numbers()//validate numbers 
        {
            string contact_no_rule = @"^0\d{9}$";
            var salary_validate = int.TryParse(txtMonthlySalary.Text, out int n);

            //var allowance_validate = int.TryParse(txtAllowances.Text, out int b);

            var overtimerate_validate = int.TryParse(txtOvertimerate.Text, out int a);
 

            if (salary_validate == true && overtimerate_validate == true )
            {
                if (Regex.IsMatch(txtContactNo.Text, contact_no_rule)==false)
                {
                    MessageBox.Show("Contact Number should consist 10 digits", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                MessageBox.Show("Monthly Salary, Overtime rate  and Contact Number should be consist of numbers", "Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }






        }

        private string position_allowance()//choose relevant allowance according to position
        {
            if (string.IsNullOrEmpty(cmbposition.Text) == false)
            {
                string allowance_query = "SELECT Allowance FROM position_allowance_details WHERE Position=@position";
                SqlCommand cmd = new SqlCommand(allowance_query, conn);

                cmd.Parameters.AddWithValue("@Position", cmbposition.Text);

                conn.Open();
                object allowance_o = cmd.ExecuteScalar();


                string allowance_s = allowance_o.ToString();
                conn.Close();

                return allowance_s;
            }
            else
            {
                return " ";
            }

        }

        public void fillcmbboxdropdown()//designing drop down menu
        {
            cmbposition.Items.Clear();


            string pos_query = "SELECT Position FROM position_allowance_details";
            SqlCommand cmd = new SqlCommand(pos_query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbposition.Items.Add(dr["Position"].ToString());
            }
            conn.Close();
        }

        private void cmbposition_SelectedIndexChanged(object sender, EventArgs e)
        {

            string allowance = position_allowance();
            txtAllowances.Text = allowance;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear_all_fields();

        }

        private void clear_all_fields()// clear all fields when necessary
        {
            radiobtnfemale.Checked = false;
            radiobtnMale.Checked = false;
            radiobtnother.Checked = false;
            txtAddress.Clear();
            txtAllowances.Clear();
            txtContactNo.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtMonthlySalary.Clear();
            txtOvertimerate.Clear();
            txtCity.Clear();
            txtNICNo.Clear();
            cmbDisctricts.SelectedIndex = -1;
            cmbposition.SelectedIndex = -1;
        }

        private void insert_record() // add record to the database
        {
            string query = "INSERT INTO Employees_New2(Fname,Mname,Lname,Gender,MonthlySalary,Allowances,OvertimeRate,RegisteringDate,BirthDate,ContactNo,Emp_Address,Position,NICNo,City,District) VALUES('" + txtFirstName.Text.ToLower() + "','" + txtMiddleName.Text.ToLower() + "','" + txtLastName.Text.ToLower() + "','" + gender + "','" + txtMonthlySalary.Text + "','" + txtAllowances.Text + "','" + txtOvertimerate.Text + "','" + dateTimePicker2.Value + "','" + dateTimePicker1.Value + "','" + txtContactNo.Text + "','" + txtAddress.Text.ToLower() + "','" + cmbposition.Text.ToLower() + "','"+txtNICNo.Text+"','"+txtCity.Text.ToLower()+"','"+cmbDisctricts.Text.ToLower()+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Added Successfully", "Employee Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear_all_fields();
            load_emp_id();
            return;
        }

        private bool isRecordDuplicate() // detect duplicates
        {
            string query = "SELECT COUNT(*) FROM Employees_New2 WHERE NICNo = @nic";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nic", txtNICNo.Text);
            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return  count > 0;
            ;
        }

        private bool validate_nic()// validate nic number
        {
            string nic_no = txtNICNo.Text;
            string pattern_old = @"^[6-9]\d{8}v$";
            string pattern_new = @"^\d{12}$";

           
                if (Regex.IsMatch(nic_no, pattern_old) || Regex.IsMatch(nic_no, pattern_new))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Invalid NIC number", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            
        }

        private void load_emp_id()// retrieve the last employee id from the database
        {
            string emp_id_query = "SELECT TOP 1 EmployeeNo FROM Employees_New2 ORDER BY EmployeeNo DESC";
            SqlCommand cmd = new SqlCommand(emp_id_query, conn);
            conn.Open();
            object id_s = cmd.ExecuteScalar();
            int id = Convert.ToInt32(id_s);
            if (id == -1)
            {
                id = 1;
            }
            else
            {
                id++;
            }
            lblEmployeeNo.Text = "EMP" + Convert.ToString(id);
            conn.Close();
        }
    }
}
