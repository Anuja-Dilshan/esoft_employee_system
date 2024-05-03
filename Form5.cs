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
    public partial class frmEmployeeOps : Form
    {
        public frmEmployeeOps()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployee employee = new frmEmployee();//form 3
            this.Hide();
            employee.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main_page = new frmMain();
            this.Hide();
            main_page.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmupdateemp update_pg = new frmupdateemp();//form 6

            update_pg.update_1 = true;
            update_pg.delete_1 = false;
            update_pg.search_1 = false;
            this.Hide();
            update_pg.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmupdateemp delete_pg = new frmupdateemp();

            delete_pg.update_1 = false;
            delete_pg.delete_1 = true;
            delete_pg.search_1 = false;
            this.Hide();
            delete_pg.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)// form 8
        {
            frmupdateemp search_pg = new frmupdateemp();
            search_pg.update_1 = false;
            search_pg.search_1 = true;
            search_pg.delete_1 = false;
            this.Hide();
            search_pg.ShowDialog();

        }

        private void btnViewemps_Click(object sender, EventArgs e)
        {
            frmviewall viewall_pg = new frmviewall();
            this.Hide();
            viewall_pg.ShowDialog();
        }
    }
}
