using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace esoft_employee_system
{
    public partial class frmupdatingmainpg : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=ANUJA-DILSHAN\\SQLEXPRESS;Initial Catalog=employee_management_system;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

        string gender;

        List<string> nicNos = new List<string>();
        public bool search { get; set; }
        public bool update { get; set; }
        public bool delete { get; set; }
        public string employeeid { get; set; }

        string initial_nic;
        public frmupdatingmainpg()
        {
            InitializeComponent();
        }

        private void frmupdatingmainpg_Load(object sender, EventArgs e)
        {
            lblheader.Text = $"Details of the EMP{employeeid}";
            lblempid.Text = $"EMP{employeeid}";
            data_recieve();
            fillpositiondropdown();
            ifSearch();

        }



        private void data_recieve()
        {
            string query = "SELECT * FROM Employees_New2 WHERE EmployeeNo = @employeeid";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@employeeid", employeeid);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Check if any rows are returned
                if (reader.Read())
                {
                    // Retrieve data from each column and set it to the respective text boxes
                    txtfname.Text = reader["Fname"].ToString();
                    txtmname.Text = reader["Mname"].ToString();
                    txtlname.Text = reader["Lname"].ToString();
                    txtaddress.Text = reader["EMP_Address"].ToString();
                    txtmonthlysalary.Text = reader["MonthlySalary"].ToString();
                    txtovertimerate.Text = reader["OvertimeRate"].ToString();
                    txtcontactno.Text = "0" + reader["ContactNo"].ToString();
                    cmbboxposition.Text = reader["Position"].ToString();
                    cmbboxdistrict.Text = reader["District"].ToString();
                    txtnic.Text = reader["NICNo"].ToString();
                    txtallowances.Text = reader["Allowances"].ToString();
                    txtcity.Text = reader["City"].ToString();
                    string gender = reader["Gender"].ToString();
                    initial_nic = reader["NICNo"].ToString();

                    if (gender == "male")
                    {
                        radiobtnmale.Checked = true;
                    }
                    else if (gender == "female")
                    {
                        radiobtnfemale.Checked = true;
                    }
                    else
                    {
                        radiobtnother.Checked = true;
                    }

                    DateTime registringdate = reader.GetDateTime(8);
                    DateTime birthdate = reader.GetDateTime(9);

                    dtpbirthdate.Value = birthdate;
                    dtpregistereddate.Value = registringdate;

                    // Continue setting data for other columns...
                }


                reader.Close();


            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private string position_allowance()//choose relevant allowance according to position
        {
            if (string.IsNullOrEmpty(cmbboxposition.Text) == false)
            {
                string allowance_query = "SELECT Allowance FROM position_allowance_details WHERE Position=@position";
                SqlCommand cmd = new SqlCommand(allowance_query, conn);

                cmd.Parameters.AddWithValue("@Position", cmbboxposition.Text);

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

        private void cmbboxposition_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtallowances.Text = position_allowance();
        }


        public void fillpositiondropdown()//designing drop down menu
        {
            cmbboxposition.Items.Clear();


            string pos_query = "SELECT Position FROM position_allowance_details";
            SqlCommand cmd = new SqlCommand(pos_query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbboxposition.Items.Add(dr["Position"].ToString());
            }
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (update == true && delete == false)
            {
                if (null_data_checker() == false)
                {
                    if (validate_numbers() && validate_nic() == true)
                    {

                        try
                        {
                            if (isRecordDuplicate())
                            {
                                MessageBox.Show("Similar NIC number already exists", "Duplicate NIC Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            update_record();
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
            else if (update == false && delete == true)
            {
                DialogResult user_pref = MessageBox.Show("Deleting this record will permanently remove it from the system. This action cannot be undone.", "Deleting the record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (user_pref == DialogResult.Yes)
                {
                    delete_records();

                }

            }


        }

        private bool isRecordDuplicate() // detect duplicates
        {
            string query = "SELECT NICNo FROM Employees_New2";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nicNo = reader.GetString(0);
                nicNos.Add(nicNo);
            }

            reader.Close();
            conn.Close();

            nicNos.Remove(initial_nic);
            foreach (string nic in nicNos)
            {
                if (txtnic.Text == nic)
                {
                    return true;
                }
                return false;
            }
            return false;

        }

        private bool validate_nic()// validate nic number
        {
            string nic_no = txtnic.Text;
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

        private void update_record() // add record to the database
        {
            if (radiobtnmale.Checked == true)
            {
                gender = "male";
            }
            else if (radiobtnfemale.Checked == true)
            {
                gender = "female";
            }
            else
            {
                gender = "other";
            }

            DialogResult user_pref = MessageBox.Show("The changes will be updated and old data will lost completely", "Updating the record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (user_pref == DialogResult.Yes)
            {
                string query = "UPDATE Employees_New2 SET Fname=@fname, Mname=@mname, Lname=@lname, Gender=@gender, MonthlySalary=@monthlysalary, Allowances=@allowances, OvertimeRate=@overtimerate, BirthDate=@birthdate, ContactNo=@contact, Position=@position, EMP_Address = @address, City=@city,District=@district, NICNo=@nicno WHERE EmployeeNo=@employeeno";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@fname", txtfname.Text.ToLower());
                cmd.Parameters.AddWithValue("@mname", txtmname.Text.ToLower());
                cmd.Parameters.AddWithValue("@lname", txtlname.Text.ToLower());
                cmd.Parameters.AddWithValue("@gender", gender.ToLower());
                cmd.Parameters.AddWithValue("@monthlysalary", txtmonthlysalary.Text);
                cmd.Parameters.AddWithValue("@allowances", txtallowances.Text);
                cmd.Parameters.AddWithValue("@overtimerate", txtovertimerate.Text);
                cmd.Parameters.AddWithValue("@birthdate", dtpbirthdate.Value);
                cmd.Parameters.AddWithValue("@contact", txtcontactno.Text);
                cmd.Parameters.AddWithValue("@position", cmbboxposition.Text.ToLower());
                cmd.Parameters.AddWithValue("@address", txtaddress.Text.ToLower());
                cmd.Parameters.AddWithValue("@district", cmbboxdistrict.Text.ToLower());
                cmd.Parameters.AddWithValue("@city", txtcity.Text.ToLower());
                cmd.Parameters.AddWithValue("@nicno", txtnic.Text);
                cmd.Parameters.AddWithValue("@employeeno", employeeid);



                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record updated Successfully", "Employee Detail Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_all_fields();
            }


        }

        private void clear_all_fields()// clear all fields when necessary
        {
            radiobtnfemale.Checked = false;
            radiobtnmale.Checked = false;
            radiobtnother.Checked = false;
            txtaddress.Clear();
            txtallowances.Clear();
            txtcontactno.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txtmname.Clear();
            txtmonthlysalary.Clear();
            txtovertimerate.Clear();
            txtcity.Clear();
            txtnic.Clear();
            cmbboxdistrict.SelectedIndex = -1;
            cmbboxposition.SelectedIndex = -1;
        }

        private bool null_data_checker()//check for null data
        {
            if (string.IsNullOrEmpty(txtfname.Text) || string.IsNullOrEmpty(txtlname.Text) || string.IsNullOrEmpty(txtmonthlysalary.Text) || string.IsNullOrEmpty(txtovertimerate.Text) || string.IsNullOrEmpty(txtcontactno.Text) || string.IsNullOrEmpty(txtaddress.Text) || string.IsNullOrEmpty(txtnic.Text) || string.IsNullOrEmpty(txtcity.Text) || string.IsNullOrEmpty(cmbboxdistrict.Text) || string.IsNullOrEmpty(cmbboxposition.Text))
            {
                MessageBox.Show("You cant keep null data", "Null Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //btnADD.Enabled = false;
                return true;
            }
            else if (radiobtnfemale.Checked == false && radiobtnmale.Checked == false && radiobtnother.Checked == false)
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

        private void button1_Click(object sender, EventArgs e)
        {
            data_recieve();
            txtallowances.Text = position_allowance();

        }

        private bool validate_numbers()//validate numbers 
        {
            string contact_no_rule = @"^0\d{9}$";
            var salary_validate = int.TryParse(txtmonthlysalary.Text, out int n);

            //var allowance_validate = int.TryParse(txtAllowances.Text, out int b);

            var overtimerate_validate = int.TryParse(txtovertimerate.Text, out int a);


            if (salary_validate == true && overtimerate_validate == true)
            {
                if (Regex.IsMatch(txtcontactno.Text, contact_no_rule) == false)
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

        private void btnback_Click(object sender, EventArgs e)
        {
            frmupdateemp update_pg = new frmupdateemp();
            if (search == true && update == false && delete == false)
            {
                update_pg.update_1 = false;
                update_pg.delete_1 = false;
                update_pg.search_1 = true;
            }
            else if (search == false && update == true && delete == false)
            {
                update_pg.update_1 = true;
                update_pg.delete_1 = false;
                update_pg.search_1 = false;
            }
            else if (search == false && update == false && delete == true)
            {
                update_pg.update_1 = false;
                update_pg.delete_1 = true;
                update_pg.search_1 = false;
            }
            this.Hide();
            update_pg.ShowDialog();


            //frmEmployeeOps emp_ops = new frmEmployeeOps();
            //this.Hide();
            //emp_ops.Show();
        }

        private void ifSearch()
        {
            if (search == true && update == false && delete == false)
            {
                txtaddress.ReadOnly = true;
                txtfname.ReadOnly = true;
                txtcity.ReadOnly = true;
                txtcontactno.ReadOnly = true;
                txtlname.ReadOnly = true;
                txtmname.ReadOnly = true;
                txtmonthlysalary.ReadOnly = true;
                txtnic.ReadOnly = true;
                txtovertimerate.ReadOnly = true;
                cmbboxdistrict.Enabled = false;
                cmbboxposition.Enabled = false;
                dtpbirthdate.Enabled = false;
                btnUpdate.Hide();
                btnrefresh.Hide();
                radiobtnfemale.Enabled = false;
                radiobtnmale.Enabled = false;
                radiobtnother.Enabled = false;
                btnback.Location = new Point(567, 730);
                frmupdatingmainpg this_page = new frmupdatingmainpg();
                this_page.Text = "GRIFINDOR - SEARCH EMPLOYEE DETAILS";
            }

            else if (search == false && update == false && delete == true)
            {
                txtaddress.ReadOnly = true;
                txtfname.ReadOnly = true;
                txtcity.ReadOnly = true;
                txtcontactno.ReadOnly = true;
                txtlname.ReadOnly = true;
                txtmname.ReadOnly = true;
                txtmonthlysalary.ReadOnly = true;
                txtnic.ReadOnly = true;
                txtovertimerate.ReadOnly = true;
                cmbboxdistrict.Enabled = false;
                cmbboxposition.Enabled = false;
                dtpbirthdate.Enabled = false;
                btnUpdate.Text = "DELETE";
                btnrefresh.Hide();
                radiobtnfemale.Enabled = false;
                radiobtnmale.Enabled = false;
                radiobtnother.Enabled = false;
            }


        }

        private void delete_records()
        {
            string query = "DELETE FROM Employees_New2 WHERE EmployeeNo = @employeeid";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@employeeid", employeeid);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("The record deleted successfully", "The record deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dtpbirthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        //private void frmupdatingmainpg_VisibleChanged(object sender, EventArgs e)
        //{
        //    if (this.Visible)
        //    {
        //        //frmupdatingmainpg_Load(sender,e);
        //    }

        //}


    }

}
