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
    public partial class frmviewall : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=ANUJA-DILSHAN\\SQLEXPRESS;Initial Catalog=employee_management_system;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

        public frmviewall()
        {
            InitializeComponent();
            //dataGridView1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            dataGridView1.Dock = DockStyle.Fill;
            btnback.Dock = DockStyle.Fill;  
        }

        private void frmviewall_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Employees_New2";

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmEmployeeOps emp_ops = new frmEmployeeOps();  
            this.Hide();
            emp_ops.ShowDialog();   
        }
    }
}
