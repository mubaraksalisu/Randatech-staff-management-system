using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace final_project
{
    public partial class AdminUpdate : Form
    {
        public AdminUpdate()
        {
            InitializeComponent();
        }

        private void adminTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employee_DBDataSet2);

        }

        private void AdminUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_DBDataSet2.AdminTable' table. You can move, or remove it, as needed.
            this.adminTableTableAdapter.Fill(this.employee_DBDataSet2.AdminTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Form L = new Login_Form();
            L.Show();
            this.Hide();
        }
    }
}
