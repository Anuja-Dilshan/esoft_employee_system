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


    public partial class frmMain : Form
    {
        public string user_name { get; set; }
        public string password { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeOps employee_ops = new frmEmployeeOps();
            this.Hide();
            employee_ops.Show();

        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            frmSalary salary_page = new frmSalary();
            this.Hide();
            salary_page.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmsettings settings_pg = new frmsettings();
            this.Hide();
            settings_pg.Show();
        }
    }
}
